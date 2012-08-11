using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EVETool {

    public partial class ResourcePanel : UserControl
    {
        public ResourcePanel()
        {
            InitializeComponent();
            ResourceTier.Items.Add("Tier 1");
            ResourceTier.Items.Add("Tier 2");
            ResourceTier.Items.Add("Tier 3");
            ResourceTier.Items.Add("Tier 4");
            ResourceTier.Visible = true;
        }
        private void ResourceTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DesiredProduct.Items.Clear();
                DesiredLabel.Visible = true;
                DesiredProduct.Visible = true;
                if (ResourceTier.SelectedIndex == 0)
                {
                    SIDataSetTableAdapters.P1_QueryTableAdapter P1TableAdapter = new SIDataSetTableAdapters.P1_QueryTableAdapter();
                    SIDataSet.P1_QueryDataTable P1DataTable = new SIDataSet.P1_QueryDataTable();
                    P1TableAdapter.Fill(P1DataTable);
                    for (int i = 0; i < P1DataTable.Rows.Count; i++)
                        DesiredProduct.Items.Add(P1DataTable.Rows[i]["P1"].ToString());
                }
                if (ResourceTier.SelectedIndex == 1)
                {
                    SIDataSetTableAdapters.P2_QueryTableAdapter P2TableAdapter = new SIDataSetTableAdapters.P2_QueryTableAdapter();
                    SIDataSet.P2_QueryDataTable P2DataTable = new SIDataSet.P2_QueryDataTable();
                    P2TableAdapter.Fill(P2DataTable);
                    for (int i = 0; i < P2DataTable.Rows.Count; i++)
                        DesiredProduct.Items.Add(P2DataTable.Rows[i]["P2"].ToString());
                }
                if (ResourceTier.SelectedIndex == 2)
                {
                    SIDataSetTableAdapters.P3_QueryTableAdapter P3TableAdapter = new SIDataSetTableAdapters.P3_QueryTableAdapter();
                    SIDataSet.P3_QueryDataTable P3DataTable = new SIDataSet.P3_QueryDataTable();
                    P3TableAdapter.Fill(P3DataTable);
                    for (int i = 0; i < P3DataTable.Rows.Count; i++)
                        DesiredProduct.Items.Add(P3DataTable.Rows[i]["P3"].ToString());
                }
                if (ResourceTier.SelectedIndex == 3)
                {
                    SIDataSetTableAdapters.P4TableAdapter P4TableAdapter = new SIDataSetTableAdapters.P4TableAdapter();
                    SIDataSet.P4DataTable P4DataTable = new SIDataSet.P4DataTable();
                    P4TableAdapter.Fill(P4DataTable);
                    for (int i = 0; i < P4DataTable.Rows.Count; i++)
                        DesiredProduct.Items.Add(P4DataTable.Rows[i]["P4"].ToString());
                }
            }
            catch (System.Exception)
            {
                Popup error = new Popup("Database Error", "There has been a problem with the Database. Are you sure it is in the same location as the EXE?");
                error.Show();
            }
        }
        private void DesiredProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateUsingLabel.Visible = true;
            CalculateUsing.Visible = true;
        }
        private void CalculateUsing_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            Value.Visible = true;
            if (CalculateUsing.SelectedIndex == 0) {
                MassLabel.Visible = false;
                QuantityUnits.Visible = true;
            }
            if (CalculateUsing.SelectedIndex == 1) {
                QuantityUnits.Visible = false;
                MassLabel.Visible = true;
            }
        }
        private void BuildResult_Click_1(object sender, EventArgs e)
        {
            try
            {
                String Quantity;
                Quantity = Value.Text;
                ResultsPanel.Controls.Clear();
                if (ResourceTier.SelectedIndex == 0)
                {
                    SIDataSetTableAdapters.P1_QueryTableAdapter P1TableAdapter = new SIDataSetTableAdapters.P1_QueryTableAdapter();
                    SIDataSet.P1_QueryDataTable P1DataTable = new SIDataSet.P1_QueryDataTable();
                    P1TableAdapter.Fill(P1DataTable);
                    List<String> P1Resources = new List<String>();
                    for (int i = 0; i < P1DataTable.Columns.Count; i++)
                        P1Resources.Add(P1DataTable.Rows[DesiredProduct.SelectedIndex][i].ToString());
                    ResultsPanel.Controls.Add(new P1(P1Resources, CalculateUsing.SelectedIndex, Convert.ToDouble(Quantity)));
                }
                if (ResourceTier.SelectedIndex == 1)
                {
                    SIDataSetTableAdapters.P2_QueryTableAdapter P2TableAdapter = new SIDataSetTableAdapters.P2_QueryTableAdapter();
                    SIDataSet.P2_QueryDataTable P2DataTable = new SIDataSet.P2_QueryDataTable();
                    P2TableAdapter.Fill(P2DataTable);
                    List<String> P2Resources = new List<String>();
                    for (int i = 0; i < P2DataTable.Columns.Count; i++)
                        P2Resources.Add(P2DataTable.Rows[DesiredProduct.SelectedIndex][i].ToString());
                    ResultsPanel.Controls.Add(new P2(P2Resources, CalculateUsing.SelectedIndex, Convert.ToDouble(Quantity)));
                }
                if (ResourceTier.SelectedIndex == 2)
                {
                    if (DesiredProduct.SelectedIndex == 0 || DesiredProduct.SelectedIndex == 3 || DesiredProduct.SelectedIndex == 5 || DesiredProduct.SelectedIndex == 7 || DesiredProduct.SelectedIndex == 13 || DesiredProduct.SelectedIndex == 16)
                    {
                        int index = 0;
                        switch (DesiredProduct.SelectedIndex)
                        {
                            case 0:
                                index = 0;
                                break;
                            case 3:
                                index = 1;
                                break;
                            case 5:
                                index = 2;
                                break;
                            case 7:
                                index = 3;
                                break;
                            case 13:
                                index = 4;
                                break;
                            case 16:
                                index = 5;
                                break;
                        }
                        SIDataSetTableAdapters.P3_Query_3_P2TableAdapter P3TableAdapter = new SIDataSetTableAdapters.P3_Query_3_P2TableAdapter();
                        SIDataSet._P3_Query_3_P2DataTable P3DataTable = new SIDataSet._P3_Query_3_P2DataTable();
                        P3TableAdapter.Fill(P3DataTable);
                        List<String> P3Resources = new List<String>();
                        for (int i = 0; i < P3DataTable.Columns.Count; i++)
                            P3Resources.Add(P3DataTable.Rows[index][i].ToString());
                        ResultsPanel.Controls.Add(new P3_3(P3Resources, CalculateUsing.SelectedIndex, Convert.ToDouble(Quantity)));
                    }
                    else
                    {
                        SIDataSetTableAdapters.P3_QueryTableAdapter P3TableAdapter = new SIDataSetTableAdapters.P3_QueryTableAdapter();
                        SIDataSet.P3_QueryDataTable P3DataTable = new SIDataSet.P3_QueryDataTable();
                        P3TableAdapter.Fill(P3DataTable);
                        List<String> P3Resources = new List<String>();
                        for (int i = 0; i < P3DataTable.Columns.Count; i++)
                            P3Resources.Add(P3DataTable.Rows[DesiredProduct.SelectedIndex][i].ToString());
                        ResultsPanel.Controls.Add(new P3_2(P3Resources, CalculateUsing.SelectedIndex, Convert.ToDouble(Quantity)));
                    }
                }
                if (ResourceTier.SelectedIndex == 3)
                {
                    if (DesiredProduct.SelectedIndex == 2 || DesiredProduct.SelectedIndex == 3 || DesiredProduct.SelectedIndex == 6)
                    {

                    }
                    else
                    {

                    }
                }
            }
            catch (System.FormatException)
            {
                Popup error = new Popup("Format Exception", "There has been a problem Calculating your request. Are you sure you have filled in the Tier, Resource, and Quantity?");
                error.Show();
            }
            /*catch (System.Exception)
            {
                Popup error = new Popup("Error", "I'm Sorry. An error has occurred.");
                error.Show();
            }*/
        }
    }
}
