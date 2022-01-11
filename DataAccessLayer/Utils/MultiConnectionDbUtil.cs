using System;
using System.Transactions;

namespace SmayDbEditor.DataAccessLayer.Utils
{
    public static class MultiConnectionDbUtil
    {
        public static void Do(Action action)
        {
            using (var scope = new TransactionScope())
            {
                try
                {
                    action();

                    scope.Complete();
                }
                catch (Exception e)
                {
                    //log
                    throw e;
                }
            }
        }
    }
}
