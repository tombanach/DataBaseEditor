﻿using SmayDbEditor.DataAccessLayer.Models;
using SmayDbEditor.DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmayDbEditor.UserInterface.Helpers
{
    // Mapowanie ViewModelu z Modelem
    public class MappingHelper
    {
        #region OrdersCorrection

        public static IList<OrderCorrectionViewModel> MapOrderCorrectionModelToOrderCorrectionViewModel
            (IEnumerable<OrderCorrectionModel> ordersCorrectionModel)
        {
            IList<OrderCorrectionViewModel> ordersCorrectionViewModel = new List<OrderCorrectionViewModel>();

            foreach (OrderCorrectionModel orderCorrectionModel in ordersCorrectionModel)
            {
                OrderCorrectionViewModel orderCorrectionViewModel = new OrderCorrectionViewModel();
                orderCorrectionViewModel.porel_id = orderCorrectionModel.porel_id;
                orderCorrectionViewModel.podet_id = orderCorrectionModel.Podet_Id;
                orderCorrectionViewModel.porel_itemcode = orderCorrectionModel.Porel_Itemcode;
                orderCorrectionViewModel.porel_pono = orderCorrectionModel.Porel_Pono;
                orderCorrectionViewModel.porel_poline = orderCorrectionModel.Porel_Poline;
                orderCorrectionViewModel.porel_qty = orderCorrectionModel.Porel_Qty;
                orderCorrectionViewModel.porel_tstamp = orderCorrectionModel.Porel_Tstamp;

                ordersCorrectionViewModel.Add(orderCorrectionViewModel);
            }

            return ordersCorrectionViewModel;
        }

        public static OrderCorrectionViewModel MapOrderCorrectionModelToOrderCorrectionViewModel(OrderCorrectionModel orderCorrectionModel)
        {
            OrderCorrectionViewModel orderCorrectionViewModel = new OrderCorrectionViewModel();
            orderCorrectionViewModel.porel_id = orderCorrectionModel.porel_id;
            orderCorrectionViewModel.podet_id = orderCorrectionModel.Podet_Id;
            orderCorrectionViewModel.porel_itemcode = orderCorrectionModel.Porel_Itemcode;
            orderCorrectionViewModel.porel_pono = orderCorrectionModel.Porel_Pono;
            orderCorrectionViewModel.porel_poline = orderCorrectionModel.Porel_Poline;
            orderCorrectionViewModel.porel_qty = orderCorrectionModel.Porel_Qty;
            orderCorrectionViewModel.porel_tstamp = orderCorrectionModel.Porel_Tstamp;

            return orderCorrectionViewModel;
        }        

        #endregion
        #region StatusChanges

        public static IList<StatusChangeViewModel> MapStatusChangeModelToStatusChangeViewModel
            (IEnumerable<StatusChangeModel> statusChangesModel)
        {
            IList<StatusChangeViewModel> statusChangesViewModel = new List<StatusChangeViewModel>();

            foreach (StatusChangeModel statusChangeModel in statusChangesModel)
            {
                StatusChangeViewModel statusChangeViewModel = new StatusChangeViewModel();
                statusChangeViewModel.imph_id = statusChangeModel.imph_id;
                statusChangeViewModel.imph_num = statusChangeModel.imph_num;
                statusChangeViewModel.imph_tstamp = statusChangeModel.imph_tstamp;
                statusChangeViewModel.imph_status = statusChangeModel.imph_status;
                statusChangeViewModel.imph_type = statusChangeModel.imph_type;

                statusChangesViewModel.Add(statusChangeViewModel);
            }

            return statusChangesViewModel;
        }

        public static StatusChangeViewModel MapStatusChangeModelToStatusChangeViewModel(StatusChangeModel statusChangeModel)
        {
            StatusChangeViewModel statusChangeViewModel = new StatusChangeViewModel();
            statusChangeViewModel.imph_id = statusChangeModel.imph_id;
            statusChangeViewModel.imph_num = statusChangeModel.imph_num;
            statusChangeViewModel.imph_tstamp = statusChangeModel.imph_tstamp;
            statusChangeViewModel.imph_status = statusChangeModel.imph_status;
            statusChangeViewModel.imph_type = statusChangeModel.imph_type;

            return statusChangeViewModel;
        }

        #endregion
        #region KanbansRemove

        public static IList<KanbanRemoveViewModel> MapKanbanRemoveModelToKanbanRemoveViewModel
            (IEnumerable<KanbanRemoveModel> kanbansRemoveModel)
        {
            IList<KanbanRemoveViewModel> kanbansRemoveViewModel = new List<KanbanRemoveViewModel>();

            foreach (KanbanRemoveModel kanbanRemoveModel in kanbansRemoveModel)
            {
                KanbanRemoveViewModel kanbanRemoveViewModel = new KanbanRemoveViewModel();
                kanbanRemoveViewModel.kbtr_id = kanbanRemoveModel.kbtr_id;
                kanbanRemoveViewModel.kbtr_polecNo = kanbanRemoveModel.kbtr_polecNo;
                kanbanRemoveViewModel.kbtr_dokID = kanbanRemoveModel.kbtr_dokID;
                kanbanRemoveViewModel.kbtr_polecDate = kanbanRemoveModel.kbtr_polecDate;
                kanbanRemoveViewModel.kbtr_relDate = kanbanRemoveModel.kbtr_relDate;
                kanbanRemoveViewModel.kbtr_status = kanbanRemoveModel.kbtr_status;
                kanbanRemoveViewModel.kbtr_tstamp = kanbanRemoveModel.kbtr_tstamp;

                kanbansRemoveViewModel.Add(kanbanRemoveViewModel);
            }

            return kanbansRemoveViewModel;
        }

        #endregion
        #region OrdersAddressChange

        public static IList<OrderAddressChangeViewModel> MapOrderAddressChangeModelToOrderAddressChangeViewModel
            (IEnumerable<OrderAddressChangeModel> ordersAddressChangeModel)
        {
            IList<OrderAddressChangeViewModel> ordersAddressChangeViewModel = new List<OrderAddressChangeViewModel>();

            foreach (OrderAddressChangeModel orderAddressChangeModel in ordersAddressChangeModel)
            {
                OrderAddressChangeViewModel orderAddressChangeViewModel = new OrderAddressChangeViewModel();
                orderAddressChangeViewModel.SOid = orderAddressChangeModel.SOid;
                orderAddressChangeViewModel.SOno = orderAddressChangeModel.SOno;
                orderAddressChangeViewModel.SOnoWMS = orderAddressChangeModel.SOnoWMS;
                orderAddressChangeViewModel.SOline = orderAddressChangeModel.SOline;
                orderAddressChangeViewModel.CustCode = orderAddressChangeModel.CustCode;
                orderAddressChangeViewModel.ItemCode = orderAddressChangeModel.ItemCode;
                orderAddressChangeViewModel.textline1 = orderAddressChangeModel.textline1;
                orderAddressChangeViewModel.QtyOrdered = orderAddressChangeModel.QtyOrdered;
                orderAddressChangeViewModel.QtyDelivered = orderAddressChangeModel.QtyDelivered;
                orderAddressChangeViewModel.DeliveryDate = orderAddressChangeModel.DeliveryDate;
                orderAddressChangeViewModel.orddate = orderAddressChangeModel.orddate;
                orderAddressChangeViewModel.DestName = orderAddressChangeModel.DestName;
                orderAddressChangeViewModel.DestCity = orderAddressChangeModel.DestCity;
                orderAddressChangeViewModel.DestAddress = orderAddressChangeModel.DestAddress;
                orderAddressChangeViewModel.DestCountry = orderAddressChangeModel.DestCountry;
                orderAddressChangeViewModel.WayOfDelivery = orderAddressChangeModel.WayOfDelivery;

                ordersAddressChangeViewModel.Add(orderAddressChangeViewModel);
            }

            return ordersAddressChangeViewModel;
        }

        public static OrderAddressChangeViewModel MapOrderAddressChangeModelToOrderAddressChangeViewModel(OrderAddressChangeModel orderAddressChangeModel)
        {

            OrderAddressChangeViewModel orderAddressChangeViewModel = new OrderAddressChangeViewModel();
            orderAddressChangeViewModel.SOid = orderAddressChangeModel.SOid;
            orderAddressChangeViewModel.SOno = orderAddressChangeModel.SOno;
            orderAddressChangeViewModel.SOnoWMS = orderAddressChangeModel.SOnoWMS;
            orderAddressChangeViewModel.SOline = orderAddressChangeModel.SOline;
            orderAddressChangeViewModel.CustCode = orderAddressChangeModel.CustCode;
            orderAddressChangeViewModel.ItemCode = orderAddressChangeModel.ItemCode;
            orderAddressChangeViewModel.textline1 = orderAddressChangeModel.textline1;
            orderAddressChangeViewModel.QtyOrdered = orderAddressChangeModel.QtyOrdered;
            orderAddressChangeViewModel.QtyDelivered = orderAddressChangeModel.QtyDelivered;
            orderAddressChangeViewModel.DeliveryDate = orderAddressChangeModel.DeliveryDate;
            orderAddressChangeViewModel.orddate = orderAddressChangeModel.orddate;
            orderAddressChangeViewModel.DestName = orderAddressChangeModel.DestName;
            orderAddressChangeViewModel.DestCity = orderAddressChangeModel.DestCity;
            orderAddressChangeViewModel.DestAddress = orderAddressChangeModel.DestAddress;
            orderAddressChangeViewModel.DestCountry = orderAddressChangeModel.DestCountry;
            orderAddressChangeViewModel.WayOfDelivery = orderAddressChangeModel.WayOfDelivery;

            return orderAddressChangeViewModel;
        }

        #endregion
        #region PrintersAdding

        public static IList<PrinterAddingViewModel> MapPrinterAddingModelToPrinterAddingViewModel
            (IEnumerable<PrinterAddingModel> printersAddingModel)
        {
            IList<PrinterAddingViewModel> printersAddingViewModel = new List<PrinterAddingViewModel>();

            foreach (PrinterAddingModel printerAddingModel in printersAddingModel)
            {
                PrinterAddingViewModel printerAddingViewModel = new PrinterAddingViewModel();
                printerAddingViewModel.id = printerAddingModel.id;
                printerAddingViewModel.PrinterName = printerAddingModel.PrinterName;
                printerAddingViewModel.hostname = printerAddingModel.hostname;

                printersAddingViewModel.Add(printerAddingViewModel);
            }

            return printersAddingViewModel;
        }

        public static PrinterAddingViewModel MapPrinterAddingModelToPrinterAddingViewModel(PrinterAddingModel printerAddingModel)
        {
            PrinterAddingViewModel printerAddingViewModel = new PrinterAddingViewModel();
            printerAddingViewModel.id = printerAddingModel.id;
            printerAddingViewModel.PrinterName = printerAddingModel.PrinterName;
            printerAddingViewModel.hostname = printerAddingModel.hostname;

            return printerAddingViewModel;
        }

        #endregion
        #region UnlockProduction

        public static IList<UnlockProductionViewModel> MapUnlockProductionModelToUnlockProductionViewModel
            (IEnumerable<UnlockProductionModel> unlockProductionsModel)
        {
            IList<UnlockProductionViewModel> unlockProductionsViewModel = new List<UnlockProductionViewModel>();

            foreach (UnlockProductionModel unlockProductionModel in unlockProductionsModel)
            {
                UnlockProductionViewModel unlockProductionViewModel = new UnlockProductionViewModel();
                unlockProductionViewModel.proccode = unlockProductionModel.ProcCode;
                unlockProductionViewModel.procname = unlockProductionModel.ProcName;
                unlockProductionViewModel.username = unlockProductionModel.UserName;
                unlockProductionViewModel.timestarted = unlockProductionModel.TimeStarted;

                unlockProductionsViewModel.Add(unlockProductionViewModel);
            }

            return unlockProductionsViewModel;
        }

        #endregion
        #region Logs

        public static IList<LogViewModel> MapLogModelToLogViewModel
            (IEnumerable<LogModel> logsModel)
        {
            IList<LogViewModel> logsViewModel = new List<LogViewModel>();

            foreach (LogModel logModel in logsModel)
            {
                LogViewModel logViewModel = new LogViewModel();
                logViewModel.log_id = logModel.log_id;
                logViewModel.log_num = logModel.Log_Num;
                logViewModel.log_descr = logModel.Log_Descr;
                logViewModel.log_tstamp = logModel.Log_Tstamp;
                logViewModel.log_error = logModel.Log_Error;

                logsViewModel.Add(logViewModel);
            }

            return logsViewModel;
        }

        public static LogViewModel MapLogModelToLogViewModel(LogViewModel logModel)
        {
            LogViewModel logViewModel = new LogViewModel();
            logViewModel.log_id = logModel.log_id;
            logViewModel.log_num = logModel.log_num;
            logViewModel.log_descr = logModel.log_descr;
            logViewModel.log_tstamp = logModel.log_tstamp;
            logViewModel.log_error = logModel.log_error;

            return logViewModel;
        }

        #endregion

        #region Registration

        public static UserViewModel MapUserModelToUserViewModel(UserModel userModel)
        {
            return new UserViewModel
            {
                Id = userModel.Id,
                Username = userModel.Username,
                UserGroups = userModel.UserGroups,
            };
        }

        #endregion
    }
}