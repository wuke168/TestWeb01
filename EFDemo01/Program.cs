using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace EFDemo01
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Entities dbcontext = new Entities();
            BCL_Goods goods = new BCL_Goods();

            //新增
            goods.SysNo = Guid.NewGuid();
            goods.GoodsTitle = "ceshi";
            goods.ArticleNo = "AAAAAAA";
            goods.UserSysNo = Guid.NewGuid();
            goods.SkuId = "11111";
            goods.CategorySysNo = Guid.NewGuid();
            goods.Weight = 100;
            goods.ClearAmount = 1;
            goods.PackageAmount = 1;
            goods.MarginAmount = 1;
            goods.OutAmount = 1;
            goods.SendAmount = 1;
            goods.BarCode = "22222";
            goods.SetsLableSysNo = Guid.NewGuid();
            goods.LastDate = DateTime.Now;
            goods.ServiceAmount = 1;
            goods.BrandSysNo = Guid.NewGuid();

            dbcontext.Entry<BCL_Goods>(goods).State = EntityState.Modified;

            //查询
            //var nowGoods = from g in dbcontext.BCL_Goods where g.ArticleNo == "AAAAA" select g;

            //foreach (var g in nowGoods)
            //{
            //    Console.WriteLine(g.ArticleNo + "---" + g.GoodsTitle);
            //}

            dbcontext.SaveChanges();
        }
    }
}
