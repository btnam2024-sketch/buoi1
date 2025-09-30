using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Singleton
{
    static Singleton instance;

    // Hàm khởi tạo được bảo vệ

    protected Singleton()
    {
    }

    public static Singleton Instance()
    {
        // Khởi tạo chậm
        // Lưu ý: Đây không phải luồng an toàn
        if (instance == null)
        {
            instance = new Singleton();
        }

        return instance;
    }
}