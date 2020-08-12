using System;

namespace LuaChonVaTinhDienTich
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao lua chon va tinh dien tich tuong ung voi hinh tron , hinh vuong , hinh chu nhat");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Lua chon hinh tron : 1 \nLua chon hinh vuong : 2 \nLua chon hinh chu nhat: 3");
            int lua_chon;
            int.TryParse(Console.ReadLine(), out lua_chon);
            double dien_tich = 0.0;
            switch (lua_chon)
            {
                case 1:
                    Console.WriteLine("Hay nhap ban kinh duonng tron");
                    int r;
                    int.TryParse(Console.ReadLine(), out r);
                   dien_tich = r * r * 3.14;
                    break;
                case 2:
                    Console.WriteLine("Hay nhap canh hinh vuong");
                    int.TryParse(Console.ReadLine(),out r);
                    dien_tich = r * r;
                    break;
                case 3:
                    Console.WriteLine("Hay nhap chieu rong hinh chu nhat");
                    int.TryParse(Console.ReadLine(), out r);
                    Console.WriteLine("Hay nhap chieu dai hinh chu nhat");
                    int.TryParse(Console.ReadLine(), out int d);
                    dien_tich = r * d;
                    break;
                default:
                    break;

            }

            if (dien_tich == 0)
            {
                Console.WriteLine("Ban da nhap sai dinh dang");

            } else
            {

            Console.WriteLine("Dien tich la:{0}", dien_tich);
            }

        }
    }
}
