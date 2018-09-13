﻿using Grand.Framework.Mvc.Models;
using Grand.Framework.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using Grand.Core.Domain.Common;
using Grand.Web.Areas.Admin.Models.Common;

namespace Grand.Web.Areas.Admin.Models.Orders
{
    public partial class ReturnRequestModel : BaseGrandEntityModel
    {
        public ReturnRequestModel()
        {
            Items = new List<ReturnRequestItemModel>();
        }

        [GrandResourceDisplayName("Admin.ReturnRequests.Fields.ID")]
        public override string Id { get; set; }

        [GrandResourceDisplayName("Admin.ReturnRequests.Fields.ID")]
        public int ReturnNumber { get; set; }

        [GrandResourceDisplayName("Admin.ReturnRequests.Fields.Order")]
        public string OrderId { get; set; }
        public int OrderNumber { get; set; }

        [GrandResourceDisplayName("Admin.ReturnRequests.Fields.Customer")]
        public string CustomerId { get; set; }
        [GrandResourceDisplayName("Admin.ReturnRequests.Fields.Customer")]
        public string CustomerInfo { get; set; }

        [GrandResourceDisplayName("Admin.ReturnRequests.Fields.Total")]
        public string Total { get; set; }

        [GrandResourceDisplayName("Admin.ReturnRequests.Fields.CustomerComments")]
        public string CustomerComments { get; set; }

        [GrandResourceDisplayName("Admin.ReturnRequests.Fields.StaffNotes")]
        public string StaffNotes { get; set; }

        [GrandResourceDisplayName("Admin.ReturnRequests.Fields.Status")]
        public int ReturnRequestStatusId { get; set; }
        [GrandResourceDisplayName("Admin.ReturnRequests.Fields.Status")]
        public string ReturnRequestStatusStr { get; set; }

        [GrandResourceDisplayName("Admin.ReturnRequests.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [GrandResourceDisplayName("Admin.ReturnRequests.Fields.Quantity")]
        public int Quantity { get; set; }

        [GrandResourceDisplayName("Admin.ReturnRequests.Fields.PickupDate")]
        public DateTime PickupDate { get; set; }

        [GrandResourceDisplayName("Admin.ReturnRequests.Fields.PickupAddress")]
        public AddressModel PickupAddress { get; set; }

        public List<ReturnRequestItemModel> Items { get; set; }

        [GrandResourceDisplayName("Admin.ReturnRequests.NotifyCustomer")]
        public bool NotifyCustomer { get; set; }

        public class ReturnRequestItemModel : BaseGrandEntityModel
        {
            public string ProductId { get; set; }

            public string ProductName { get; set; }

            public string UnitPrice { get; set; }

            public int Quantity { get; set; }

            public string ReasonForReturn { get; set; }

            public string RequestedAction { get; set; }
        }
    }
}