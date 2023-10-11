using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session34_EntityFramework.Pages.StudentForms
    {
    public partial class Actions : System.Web.UI.Page
        {
        protected void Page_Load ( object sender, EventArgs e )
            {
            if (Request.QueryString["ID"] == null)
                {
                Response.Redirect("~/Pages/ErrorPages/ErrorPage.html", true);
                return;
                }
            else
                {
                string strID = Request.QueryString["ID"];
                if (strID.Trim() == "-1")
                    {      //came for insert
                    btnDelete.Visible = false;
                    btnUpdate.Visible = false;
                    }
                else
                    {    //came for update and/or delete
                    if (!IsPostBack) { 
                    btnInsert.Visible = false;
                    long stuID = Convert.ToInt64(strID);
                    Models.DB_ASPEntityEntities Context = new Models.DB_ASPEntityEntities();
                    var queryStudent = Context.Students.Where(st => st.ID == stuID).FirstOrDefault();
                    if (queryStudent != null)
                        {
                        txtName.Value = queryStudent.Name;
                        txtFamily.Value = queryStudent.LastName;
                        }
                    else
                        {
                        Response.Redirect("Index.aspx");
                        return;
                            }
                        }
                    }
                }
            }

        protected void btnInsert_Click ( object sender, EventArgs e )
            {
            if (txtName.Value.Trim() != string.Empty && txtName.Value.Trim() != null
                && txtFamily.Value.Trim() != string.Empty & txtFamily.Value.Trim() != null)
                {
                Models.Student stu = new Models.Student()
                    {
                    Name = txtName.Value,
                    LastName = txtFamily.Value
                    };
                Models.DB_ASPEntityEntities Context = new Models.DB_ASPEntityEntities();
                Context.Students.Add(stu);
                Context.SaveChanges();

                //reload the grid when client clicked the button
                ScriptManager.RegisterStartupScript(Page, typeof(Page),
                    "MyScript", "window.opener.location.reload();", true);
                txtName.Value = string.Empty;
                txtFamily.Value = string.Empty;
                }
            }

        protected void btnUpdate_Click ( object sender, EventArgs e )
            {
            long stuID = Convert.ToInt64(Request.QueryString["ID"]);
            Models.DB_ASPEntityEntities Context = new Models.DB_ASPEntityEntities();
            var queryStudent = Context.Students.Where(st => st.ID == stuID).FirstOrDefault();
            if (queryStudent != null)
                {

                queryStudent.Name = txtName.Value;
                queryStudent.LastName = txtFamily.Value;
                Context.SaveChanges ();
                ScriptManager.RegisterStartupScript(Page, typeof(Page),
                  "MyScript", " window.close(); window.opener.location.reload();", true);
                }
            else
                {
                Response.Redirect("Index.aspx");
                return;
                }
            }

        protected void btnDelete_Click ( object sender, EventArgs e )
            {
            long stuID = Convert.ToInt64(Request.QueryString["ID"]);
            Models.DB_ASPEntityEntities Context = new Models.DB_ASPEntityEntities();
            var queryStudent = Context.Students.Where(st => st.ID == stuID).FirstOrDefault();
            if (queryStudent != null)
                {

               Context. Students.Remove(queryStudent);
                Context.SaveChanges();
                ScriptManager.RegisterStartupScript(Page, typeof(Page),
                  "MyScript", " window.close(); window.opener.location.reload();", true);
                }
            else
                {
                Response.Redirect("Index.aspx");
                return;
                }
            }
        }
    }