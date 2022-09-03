using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //newlemeye gerek olmadığından static yapıyoruz.
    public static class Messages
    {
        //standart bir string sınıfı oluşturduk, mesajlarımızı yazmak için
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductListed = "Ürünler listelendi";

        public static string ProductCountOfCategoryError = "En fazla 10 ürün ekleyebilirsiniz.";

        public static string ProductNameAlreadyExists ="Bu isim bir ürün zaten var.";

        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
    }
}
