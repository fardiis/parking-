using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    /// <summary>
    /// این کلاس نوع و مدل ماشین را مدیریت میکند
    /// </summary>
    public class CarType
    {
        #region Properties
        public Int64 ID { get; set; }
        public string Name { get; set; }

        #endregion

        #region Crud
        public bool Insert()
        {
            string command = "INSERT into [CarType](name) values(@name)";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            var nameParameter = new SqlParameter("@name", this.Name);
            parametersList.Add(nameParameter);

            var db = new DataAccess.DatabaseManager();
            var result = db.ExecuteCommand(command, parametersList);
            return result;
        }
        public bool Update()
        {
            string command = "Update [CarType] set [name]=@name where ID=@id";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            var nameParameter = new SqlParameter("@name", this.Name);
            var idParameter = new SqlParameter("@id", this.ID);
            parametersList.Add(nameParameter);
            parametersList.Add(idParameter);

            var db = new DataAccess.DatabaseManager();
            var result = db.ExecuteCommand(command, parametersList);
            return result;
        }
        public bool Delete()
        {
            string command = "delete from [CarType] where ID=@id";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            var idParameter = new SqlParameter("@id", this.ID);
            parametersList.Add(idParameter);

            var db = new DataAccess.DatabaseManager();

            var result = db.ExecuteCommand(command, parametersList);

            return result;
        }

        public List<CarType> Read()
        {
            string command = "Select * from CarType";
            var db = new DataAccess.DatabaseManager();
            var result = db.GetData(command);

            List<CarType> lstResult = new List<CarType>();
            foreach (DataRow r in result.Rows)
            {
                CarType car = new CarType();
                car.ID = Convert.ToInt64(r["ID"]);
                car.Name = r["Name"].ToString();
                lstResult.Add(car);
            }

            return lstResult;
        }
        #endregion
    }
}
