using ECommercial.Data.Interfaces;
using ECommercial.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using ECommercial.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ECommercial.Data.Entities
{
    [Table("TB_Products")]
    public class TB_Product : DomainEntity<long>, IHasSeoMetaData, ISwitchable, IHasSoftDelete, IDateTracking
    {
        public TB_Product()
        {
            StoreStates = new List<TB_StoreState>();
        }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Model { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Unit { get; set; }
        public int? CategoryId { get; set; } //Danh mục
        public long? SupplierId { get; set; } //Nhà cung cấp
        public long? ProducerId { get; set; } //Nhà sản xuất
        [Column(TypeName = "numeric")]
        public decimal? Price { get; set; } //Giá bán lẻ
        [Column(TypeName = "numeric")]
        public decimal? PriceDealer { get; set; } //Giá bán buôn
        [Column(TypeName = "numeric")]
        public decimal? PriceOriginal { get; set; } //Giá gốc
        [Column(TypeName = "numeric")]
        public decimal? ShipSponse { get; set; } //Phí ship tài trợ cho giá lẻ
        public bool ShipIncluded { get; set; } //Đã bao gồm phí ship
        public bool InsureRequest { get; set; } //Bắt buộc mua bảo hiểm
        public bool CheckDeliveryRequest { get; set; } //Bắt buộc kiểm hàng khi nhận
        [Column(TypeName = "numeric")]
        public decimal? CheckDeliveryFee { get; set; } //Chi phí phát sinh khi kiểm hàng
        public string Brief { get; set; } //Mô tả vắn tắt
        public string Detail { get; set; } //Mô tả chi tiết
        public int? ApprovalStatus { get; set; } //Tình trạng phê duyệt hiện tại
        [StringLength(250)]
        public string ApprovalProcessing { get; set; } //Lịch sử phê duyệt
        public int? ApproverId { get; set; } //Người phê duyệt cuối cùng
        [StringLength(300)]
        public string HighLight { get; set; } //Đặc điểm nổi bật của sản phẩm
        [StringLength(300)]
        public string Picture1 { get; set; } //Hình ảnh sản phẩm
        [StringLength(300)]
        public string Picture2 { get; set; } //Hình ảnh sản phẩm
        [StringLength(1000)]
        public string MultiPicture { get; set; } //Danh sách ảnh
        public bool? NewFlag { get; set; } //Là sản phẩm mới
        public bool? HotFlag { get; set; } //Là sản phẩm hot
        public long? ViewCount { get; set; } //Đến lượt truy cập
        public long? SolCount { get; set; } //Đếm số lượng bán
        [Column(TypeName = "numeric")]
        public decimal? PackLength { get; set; } //Độ dài khi đóng gói (cm)
        [Column(TypeName = "numeric")]
        public decimal? PackWidth { get; set; } //Độ rộng khi đóng gói (cm)
        [Column(TypeName = "numeric")]
        public decimal? PackHeight { get; set; } //Chiều cao khi đóng gói (cm)
        [Column(TypeName = "numeric")]
        public decimal? PackWeight { get; set; } //Cân nặng (kg)
        [StringLength(250)]
        public string ProducerTemp { get; set; } //Tên nhà sản xuất nếu chưa có trong hệ thống
        [StringLength(300)]
        public string ProductCapacity { get; set; } //Dung tích của sản phẩm
        [StringLength(300)]
        public string ProductColor { get; set; } //Danh sách màu sắc sản phẩm
        [StringLength(300)]
        public string ProductSize { get; set; } //Danh sách kích cỡ sản phẩm
        public bool OnlyInCity { get; set; } //Chỉ bán trong nội thành
        public int? ReturnDay { get; set; } //Số ngày được phép đổi/trả
        [StringLength(300)]
        public string Warranty { get; set; } //Thông tin bảo hành
        public bool EasyBreak { get; set; } //Là hàng dễ vỡ
        public DateTime? DateCreated { get; set; } //Ngày tạo sản phẩm trên sàn
        public DateTime? DateModified {set;get;} //Ngày cập nhật cuối cùng
        public bool IsDeleted {set;get;} //Đã bị xóa khỏi sản
        public Status Status {set;get;} //Tình trạng (đang bán, đang tạm dừng)
        [StringLength(300)]
        public string SeoPageTitle {set;get;}
        [StringLength(300)]
        public string SeoAlias {set;get;}
        [StringLength(300)]
        public string SeoKeywords {set;get;}
        [StringLength(500)]
        public string SeoDescription {set;get;}
        [StringLength(255)]
        public string Tags { get; set; }

        //Các liên kết ràng buộc dữ liệu
        [ForeignKey("CategoryId")]
        public virtual TB_ProductCategory ProductCategories { get; set; }
        [ForeignKey("ProducerId")]
        public virtual TB_Producer Producers { get; set; }

        public virtual ICollection<TB_StoreState> StoreStates { get; set; }
    }
}
