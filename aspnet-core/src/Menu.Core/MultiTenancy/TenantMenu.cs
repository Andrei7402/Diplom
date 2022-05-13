using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.MultiTenancy
{
    public class TenantMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string TypeMenu { get; set; }
        public byte[] Image { get; set; }


            //Image img = Image.FromFile("путь фото");
            //ImageConverter convertObj = new ImageConverter();
            //byte[] imgByte = (byte[])convertObj.ConvertTo(img, typeof(byte[]));

            //TenantMenu tenantMenu = new TenantMenu();
            //tenantMenu.Name = "";
            //tenantMenu.Price = 3;
            //tenantMenu.Image = imgByte;

    }
}
