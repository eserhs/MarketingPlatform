using Core.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün ekledi";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductGetAll = "Ürünler Listeledi";
        public static string UserAdded = "kullanıcı ekledi";
        public static string SuccessUplodImage = "Resim başarıyla yüklendi";

        public static string AuthorizationDenied = "Yetkiniz Yok";

        public static string UserRegistered = "Kullanıcı Kayıt oldu ";
        public static string UserNotFound = "böyle bir kullanıcı yok";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "böyle bir kullanıc zaten var";
        public static string AccessTokenCreated = "token oluşturludu";

        public static string CategoryAdded = "Kategoryi Eklendi";
        public static string CategoryDeleted = "Kategori Sildi";
        public static string CategoryUpdated = "Kategori Güncellendi";
        public static string CategoryGetAll = "Kategori Listelendi";
        public static string CategoryGetById = "Kategori Id Bazılı Listeledi";

    }

}
