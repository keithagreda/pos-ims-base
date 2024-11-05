using Microsoft.EntityFrameworkCore.Metadata.Internal;
using pos_ims_base.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace pos_ims_base.Models
{
    public class SalesDetail : AuditedEntity
    {
        public Guid Id { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product ProductFk { get; set; }

        public Guid SalesHeaderId { get; set; }
        [ForeignKey("SalesHeaderId")]
        public SalesHeader SalesHeaderFk { get; set; }
        public Guid CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer CustomerFk { get; set; }
    }

    public class SalesHeader : AuditedEntity
    {
        public Guid Id { get; set; }
        public decimal TotalAmount { get; set; }
        public string TransNum { get; set; }
        public ICollection<SalesDetail> SalesDetails { get; set; }
    }

    public class Product : AuditedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }

    public class ProductCategory : AuditedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product ProductFK { get; set; }
    }

    public class StocksReceiving : AuditedEntity
    {
        public Guid Id { get; set; }
        public decimal Quantity { get; set; }
        public string TransNum { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product ProductFK { get; set; }
    }

    public class StockDamageHeader : AuditedEntity
    {
        public Guid Id { get; set; }
        public string Remarks { get; set; }
        public string TransNum { get; set; }
        public ICollection<StockDamageDetail> StockDamageDetails { get; set; }
    }

    public class StockDamageDetail : AuditedEntity
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public Guid StockDamageHeaderId { get; set; }
        [ForeignKey("StockDamageHeaderId")]
        public StockDamageHeader StockDamageHeaderFk { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product ProductFK { get; set; }
    }

    public class SalesReturn: AuditedEntity
    {
        public Guid Id { get; set; }
        public Guid SalesHeaderId { get; set; }
        [ForeignKey("SalesHeaderId")]
        public SalesHeader SalesHeaderFk { get; set; }
    }

    public class Customer : AuditedEntity
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public CustomerType CustomerType { get; set; }
        //public Guid UserId { get; set; }
    }


}
