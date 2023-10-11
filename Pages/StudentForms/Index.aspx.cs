using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session34_EntityFramework.Pages.StudentForms
    {
    public partial class Index : System.Web.UI.Page
        {
        protected void Page_Load ( object sender, EventArgs e )
            {
            GetList();
            }
        private void GetList ()
            {
            Models.DB_ASPEntityEntities Context = new Models.DB_ASPEntityEntities();
            var query = from stu in Context.Students
                        select new
                            {
                            stu.ID,
                            VorName = stu.Name,
                            Family = stu.LastName
                            };
            MyGrid.DataSource = query.ToList();
            MyGrid.DataBind();
            }
        }
    }