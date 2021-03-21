using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Reflection;
using a3.Models;
using a3.Forms;

namespace a3
{
    public class Controller
    {
        Customer c = new Customer();

        //List holds data using Customer model
        public List<Customer> AllCustomers = new List<Customer>();

        //Adds new Customer using name + autogenerate ID
        public void Add(string name)
        {
            AllCustomers.Add(new Customer(name));
        }
        //Adds new Customer using name + id - used for read txt
        public void Add(string name, string id)
        {
            AllCustomers.Add(new Customer(name, id));
        }
        //Find Customer based on name - helper for remove
        public Customer Finduser(string name)
        {
            foreach (Customer c in AllCustomers)
            {
                if (c.Name == name)
                {
                    return c;
                }
            }
            return null;
        }
        //Remover for Customer
        public void Remove(string name)
        {
            AllCustomers.Remove(Finduser(name));
        }
        //Read from txt, add to listview
        public void Display(ListView lv, Controller _c)
        {
            lv.Items.Clear();
            List<string> data = File.ReadAllLines("data.txt").ToList();
            foreach (string d in data)
            {
                string[] items = d.Split(new char[] { ',' },
                       StringSplitOptions.RemoveEmptyEntries);
                lv.Items.Add(new ListViewItem(items));
                if (lv.Items.ContainsKey(d[0].ToString()))
                {
                    MessageBox.Show("This is a duplicate netry");
                }
                else
                {
                    _c.Add(d[0].ToString(), d[1].ToString());
                }
            }
        }
        //Writes to txt
        public void WriteFile(ListView lv)
        {
            using (TextWriter tw = new StreamWriter("data.txt"))
            {
                for (int i = 0; i < lv.Items.Count; i++)
                {
                    int ii = 1;
                    tw.WriteLine(string.Format("{0},{1}", lv.Items[i].SubItems[0].Text, lv.Items[i].SubItems[1].Text));

                    ii++;
                }

            }
        }
        //Writes to listview, failsafe to make sure edits work
        public void ToListview(ListView lv, Controller _c)
        {
            lv.Items.Clear();
            foreach (Customer c in _c.AllCustomers)
            {
                lv.Items.Add(new ListViewItem(new string[] { c.Name, c._Cid }));
            }
        }

    }


}
