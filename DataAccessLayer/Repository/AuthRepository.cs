using SmayDbEditor.DataAccessLayer.Interfaces;
using SmayDbEditor.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace SmayDbEditor.DataAccessLayer.Repository
{
    public class AuthRepository : BaseRepository, IAuthRepository
    {
        private readonly IUserRepository _userRepository;
        public AuthRepository(IDbConnection connection, IUserRepository userRepository) : base(connection)
        {
            _userRepository = userRepository;
        }

        public UserModel Login(string username, string password)
        {
            var user = _userRepository.GetUserByUsername(username.ToLower());

            if (user == null)
            {
                throw new ValidationException("Podany uzytkownik nie istnieje");
            }

            if (VerifyPasswordHashSalt(password, user.PwdHash, user.PwdSalt) == false)
            {
                throw new ValidationException("Podae haslo jest nieprawidlowe");
            }

            return user;
        }

        public UserModel Register(string username, string password, UserGroupModel group)
        {
            if (username.Length < 4 || password.Length < 5)
            {
                throw new ValidationException("Nazwa użytkownika lub haslo sa za krotkie");
            }

            var user = new UserModel
            {
                Username = username,
            };

            var hashSaltResult = ConvertPasswordToHashSalt(username, password);

            if (_userRepository.GetUserByUsername(username.ToLower()) != null)
            {
                throw new ValidationException("Użytkownik już istnieje");
            }

            user.PwdHash = hashSaltResult.Hash;
            user.PwdSalt = hashSaltResult.Salt;

            user.UserGroups = new List<UserGroupModel>
            {
                group
            };

            var createdUser = _userRepository.AddUser(user);

            return createdUser;
        }

        private UserHashSaltModel ConvertPasswordToHashSalt(string username, string password)
        {
            var userHashSaltModel = new UserHashSaltModel();

            using (var h = new System.Security.Cryptography.HMACSHA512())
            {
                userHashSaltModel.Salt = Convert.ToBase64String(h.Key);
                userHashSaltModel.Hash = Convert.ToBase64String(h.ComputeHash(Encoding.UTF8.GetBytes(password)));
            }

            return userHashSaltModel;
        }

        private bool VerifyPasswordHashSalt(string passwordFromUser, string pwdHash, string pwdSalt)
        {
            var pwdHashAsByteArray = Convert.FromBase64String(pwdHash);
            var pwdSaltAsByteArray = Convert.FromBase64String(pwdSalt);

            using (var h = new System.Security.Cryptography.HMACSHA512(pwdSaltAsByteArray))
            {
                var hashFromUser = h.ComputeHash(Encoding.UTF8.GetBytes(passwordFromUser));

                for (var i = 0; i < hashFromUser.Length; i++)
                {
                    if (hashFromUser[i] != pwdHashAsByteArray[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
