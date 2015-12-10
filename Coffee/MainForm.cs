using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coffee.model;
using System.Data.Entity.Infrastructure;

using System;
using System.Linq;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;




namespace Coffee
{
    public partial class MainForm : Form
    {
        CoffeeContext cc;
        Coffee.model.Order curOrder;
        OrderItem curOrderItem;
        public MainForm()
        {
            
            InitializeComponent();

            cc = new CoffeeContext();
            cc.Enums.Load();
            cc.OrderItems.Load();
            cc.Orders.Load();
            //dataGridView1.DataSource = cc.Enums.Local.ToBindingList();
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuildButton();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ;
        }

        private void BuildButton()
        {
            int buttonCount = cc.Menus.Count();

            int x = 1;
            int y = 0;
            cc.Menus.Load();

            foreach (Coffee.model.Menu m in cc.Menus)
            {
                Button b = new Button();
                String caption = m.Enum.Name + '\n' + m.Vol + "мл" + '\n' + m.Price.ToString("0,0") + " ₽" + '\n' + "ID" +m.Id;
                b.Text = caption;
                b.Location = new Point(((x % 2 == 1) ? 20 : 200), 20 + 120 * (y / 2));
                b.Size = new Size(150, 100);
                b.Font = new Font(b.Font.Name, 15, b.Font.Style, b.Font.Unit);
                b.MouseClick += new MouseEventHandler(buttonMouseClick);
                panel1.Controls.Add(b);

                x += 1;  y += 1;                

            }
        }


        private void buttonMouseClick(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {
                curOrderItem = new OrderItem();
                String ss;
                int Id;
                int lastIndex = ((Button)sender).Text.LastIndexOf("ID");
                    if (lastIndex > 0)
                {
                    if (curOrder == null)
                    {
                        curOrder = new Order();
                        curOrder.Date = DateTime.Now.Date;
                        curOrder.Time = DateTime.Now;
                        curOrder.clientPhone = "";
                    }
                    if (curOrder.Orders.Count == 0)
                    {
                        cc.Orders.Add(curOrder);
                        cc.SaveChanges();
                    }
                    ss = ((Button)sender).Text.Substring(lastIndex, 3).Replace("ID", "").TrimEnd();
                    if (Int32.TryParse(ss, out Id))
                    {
                        Coffee.model.Menu mm = cc.Menus.Find(Id);
                        curOrderItem.MenuId = Id;
                        curOrderItem.salePrice = mm.Price;
                        curOrderItem.OrderId = curOrder.Id;
                        curOrder.Orders.Add(curOrderItem);
                        cc.OrderItems.Add(curOrderItem);
                        cc.SaveChanges();
                    }
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((curOrder != null) && (curOrder.Orders.Count() > 0))
            {
                ObjectContext context =
                    (new CoffeeContext() as IObjectContextAdapter).ObjectContext;


                ObjectQuery<OrderItem> productQuery1 =
                    new ObjectQuery<OrderItem>("OrderItems", context).Where("it.OrderId = @OrderId");
                productQuery1.Parameters.Add(new ObjectParameter("OrderId", curOrder.Id));

                
                dataGridView1.DataSource = productQuery1.Execute((MergeOption.AppendOnly));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            model.Enum ee = new model.Enum();
            ee.Name = "123123123";
            cc.Enums.Add(ee);
            cc.SaveChanges();
            /*
            Order o = new Order();
            o.clientPhone = "123";
            o.Date = DateTime.Today;
            o.Time = DateTime.Now;
            cc.Orders.Add(o);
            cc.SaveChanges();
             */ 
        }


    }
}
