using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLK.DAL
{
    class DAL_Product
    {
        Connect connect = new Connect();
        public DataTable Get()
        {
            return connect.Query("SELECT p.*, c.name category, r.name producer, o.name origin, i.create_date FROM (((product p INNER JOIN category c ON p.category_id = c.id) INNER JOIN producer r ON p.producer_id = r.id) INNER JOIN origin o ON p.origin_id = o.id) INNER JOIN import i ON p.import_id = i.id").FetchAll();
        }
        public DataTable Search(string[] value)
        {
            return connect.Query("SELECT p.*, c.name category, r.name producer, o.name origin, i.create_date FROM (((product p INNER JOIN category c ON p.category_id = c.id) INNER JOIN producer r ON p.producer_id = r.id) INNER JOIN origin o ON p.origin_id = o.id) INNER JOIN import i ON p.import_id = i.id WHERE p.name LIKE '%' + ? + '%'").Value(value).FetchAll();
        }
        public void Insert(string[] value)
        {
            connect.Query("INSERT INTO product(account_id, category_id, producer_id, import_id, origin_id, name, amount, price, warranty_period) VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?)").Value(value).Execute();
        }
        public void Update(string[] value)
        {
            connect.Query("UPDATE product SET category_id = ?, producer_id = ?, origin_id = ?, name = ?, amount = ?, price = ?, warranty_period = ?  WHERE id = ?").Value(value).Execute();
        }
        public void Delete(string[] value)
        {
            connect.Query("DELETE FROM product WHERE id = ?").Value(value).Execute();
        }
        public DataRow getID(string[] value)
        {
           DataRow data = connect.Query("SELECT * FROM product WHERE name = ? AND category_id = ? AND producer_id = ? AND origin_id = ? AND price = ?").Value(value).Fetch();
            if (data != null)
                return data;
            return null;
        }
        public int getCost(string[] value)
        {
            DataRow data = connect.Query("SELECT price FROM product WHERE id = ?").Value(value).Fetch();
            if (data != null)
                return Convert.ToInt32(data["price"]);
            return 0;
        }
        public int getAmount(string[] value)
        {
            DataRow data = connect.Query("SELECT amount FROM product WHERE id = ?").Value(value).Fetch();
            if (data != null)
                return Convert.ToInt32(data["amount"]);
            return 0;
        }
        public void UpdateAmount(string[] value)
        {
            connect.Query("UPDATE product SET amount = ? WHERE id = ?").Value(value).Execute();
        }
    }
}
