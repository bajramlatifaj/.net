using DataAccess;
using System;

public partial class SongDetalis : MultitracksPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var sql = new SQL();

        try
        {
            var data = sql.ExecuteStoredProcedureDT("GetSongsDetalis");

            songDetalis.DataSource = data;
            songDetalis.DataBind();

            //publishDB.Visible = false;
            //items.Visible = true;
        }
        catch
        {
            //publishDB.Visible = true;
            //items.Visible = false;
        }
    }
}
