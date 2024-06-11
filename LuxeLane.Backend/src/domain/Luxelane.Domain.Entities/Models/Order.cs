using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Order
{
    public Guid Id { get; set; }

    public Guid? Affiliateid { get; set; }

    public bool? Allowstoringcreditcardnumber { get; set; }

    public string? Authorizationtransactioncode { get; set; }

    public string? Authorizationtransactionid { get; set; }

    public string? Authorizationtransactionresult { get; set; }

    public Guid? Billingaddressid { get; set; }

    public string? Capturetransactionid { get; set; }

    public string? Capturetransactionresult { get; set; }

    public string? Cardcvv2 { get; set; }

    public string? Cardexpirationmonth { get; set; }

    public string? Cardexpirationyear { get; set; }

    public string? Cardname { get; set; }

    public string? Cardnumber { get; set; }

    public string? Cardtype { get; set; }

    public string? Checkoutattributedescription { get; set; }

    public string? Checkoutattributesxml { get; set; }

    public DateTime? Createdonutc { get; set; }

    public decimal? Currencyrate { get; set; }

    public string? Customvaluesxml { get; set; }

    public string? Customercurrencycode { get; set; }

    public Guid? Customerid { get; set; }

    public string? Customerip { get; set; }

    public Guid? Customerlanguageid { get; set; }

    public Guid? Customertaxdisplaytypeid { get; set; }

    public bool? Deleted { get; set; }

    public string? Maskedcreditcardnumber { get; set; }

    public decimal? Orderdiscount { get; set; }

    public Guid? Orderguid { get; set; }

    public decimal? Ordershippingexcltax { get; set; }

    public decimal? Ordershippingincltax { get; set; }

    public Guid? Orderstatusid { get; set; }

    public decimal? Ordersubtotaldiscountexcltax { get; set; }

    public decimal? Ordersubtotaldiscountincltax { get; set; }

    public decimal? Ordersubtotalexcltax { get; set; }

    public decimal? Ordersubtotalincltax { get; set; }

    public decimal? Ordertax { get; set; }

    public decimal? Ordertotal { get; set; }

    public DateTime? Paiddateutc { get; set; }

    public decimal? Paymentmethodadditionalfeeexcltax { get; set; }

    public decimal? Paymentmethodadditionalfeeincltax { get; set; }

    public string? Paymentmethodsystemname { get; set; }

    public Guid? Paymentstatusid { get; set; }

    public bool? Pickupinstore { get; set; }

    public Guid? Pickupaddressid { get; set; }

    public decimal? Refundedamount { get; set; }

    public bool? Rewardpointswereadded { get; set; }

    public Guid? Shippingaddressid { get; set; }

    public string? Shippingmethod { get; set; }

    public string? Shippingratecomputationmethodsystemname { get; set; }

    public Guid? Shippingstatusid { get; set; }

    public Guid? Storeid { get; set; }

    public string? Subscriptiontransactionid { get; set; }

    public string? Taxrates { get; set; }

    public string? Vatnumber { get; set; }

    public virtual Address? Billingaddress { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<Discountusagehistory> Discountusagehistories { get; set; } = new List<Discountusagehistory>();

    public virtual ICollection<Giftcardusagehistory> Giftcardusagehistories { get; set; } = new List<Giftcardusagehistory>();

    public virtual ICollection<Orderitem> Orderitems { get; set; } = new List<Orderitem>();

    public virtual ICollection<Ordernote> Ordernotes { get; set; } = new List<Ordernote>();

    public virtual Address? Pickupaddress { get; set; }

    public virtual ICollection<Recurringpayment> Recurringpayments { get; set; } = new List<Recurringpayment>();

    public virtual ICollection<Rewardpointshistory> Rewardpointshistories { get; set; } = new List<Rewardpointshistory>();

    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();

    public virtual Address? Shippingaddress { get; set; }
}
