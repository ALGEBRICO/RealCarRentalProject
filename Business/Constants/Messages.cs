using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalıd = "Araba ismi geçersiz en az 2 karakter olmalı";
        public static string DailyPriceInvalıd = "Araba fiyatı 0'dan büyük olmalı";
        public static string ProductsListed="Arabalar listelendi";
        public static string MaintenanceTime="Sistem 22:00'dan sonra bakıma geçer";
        public static string CarDeleted="Araba silindi";
        public static string CarUpdated="Araba bilgileri güncellendi";
        public static string BrandAdded="Marka eklendi";
        public static string BrandDeleted="Marka silindi";
        public static string BrandUpdated="Marka bilgileri güncellendi";
        public static string ColorAdded="Renk eklendi";
        public static string ColorDeleted="Renk silindi";
        public static string ColorUpdated="Renk bilgisi güncellendi";
        public static string BrandsListed="Markalar listelendi";
        public static string ColorsListed="Renkler listelendi";
        public static string RentNotAvailable="Araba mevcut değil";
        public static string RentalAdded="Kiralama yapıldı";
        public static string RentalDeleted="Kiralama kaldırıldı";
        public static string RentsListed="Kiralamalar listelendi";
        public static string RentalUpdated="Kiralama bilgisi güncellendi";
        public static string CarImageAdded="Araç resmi eklendi";
        public static string CarImageDeleted="Araç resmi silindi";
        internal static string CarImagesListed="Araç resimleri listelendi";
        internal static string CheckCarImageIsLimited = "Daha fazla araç resmi koyamazsınız";
    }
}
