namespace AssetManagement.Enums
{
    public enum AssetItemStatus
    {
        Available,      // Có sẵn, chưa được sử dụng
        InUse,          // Đang sử dụng
        Maintenance,    // Đang bảo trì, sửa chữa
        Retired,        // Đã loại bỏ, không sử dụng nữa
        Lost,           // Mất
        Damaged,        // Hư hỏng
        Reserved        // Đã được đặt trước
    }

}
