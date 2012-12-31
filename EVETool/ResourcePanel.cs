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

namespace EVETool
{

    public partial class ResourcePanel : UserControl
    {
        private List<Boolean> PlanetToggles = new List<Boolean>();
        private List<String> Planets = new List<String>();
        private List<String> StoredData = new List<String>();
        public ResourcePanel(Boolean BarrenToggle, Boolean GasToggle, Boolean IceToggle, Boolean LavaToggle, Boolean OceanicToggle, Boolean PlasmaToggle, Boolean StormToggle, Boolean TemperateToggle)
        {
            InitializeComponent();
            // Store the toggles from the ResourceWindow and puts them in variable to be used here. 
            this.PlanetToggles.Add(BarrenToggle);
            this.Planets.Add("B");
            this.PlanetToggles.Add(GasToggle);
            this.Planets.Add("G");
            this.PlanetToggles.Add(IceToggle);
            this.Planets.Add("I");
            this.PlanetToggles.Add(LavaToggle);
            this.Planets.Add("L");
            this.PlanetToggles.Add(OceanicToggle);
            this.Planets.Add("O");
            this.PlanetToggles.Add(PlasmaToggle);
            this.Planets.Add("P");
            this.PlanetToggles.Add(StormToggle);
            this.Planets.Add("S");
            this.PlanetToggles.Add(TemperateToggle);
            this.Planets.Add("T");

            // Add these values to the First dropdown box.
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
                // When the first combobox value is changed made the second combo-box visible.
                DesiredProduct.Items.Clear();
                DesiredLabel.Visible = true;
                DesiredProduct.Visible = true;


                // Depending on what value is chosen in the first combo-box pull from different queries in the ScienceIndustry Database.
                if (ResourceTier.SelectedIndex == 0) // Tier 1
                {
                    StoredData.Clear();
                    SIDataSetTableAdapters.P1_QueryTableAdapter P1TableAdapter = new SIDataSetTableAdapters.P1_QueryTableAdapter();
                    SIDataSet.P1_QueryDataTable P1DataTable = new SIDataSet.P1_QueryDataTable();
                    P1TableAdapter.Fill(P1DataTable);
                    for (int i = 0; i < P1DataTable.Rows.Count; i++)
                    {
                        StoredData.Add(P1DataTable.Rows[i]["P1"].ToString());
                        StoredData.Add(P1DataTable.Rows[i]["Planets"].ToString());
                    }

                    PopulateDesiredProduct();
                }
                if (ResourceTier.SelectedIndex == 1) // Tier 2
                {
                    StoredData.Clear();
                    SIDataSetTableAdapters.P2_QueryTableAdapter P2TableAdapter = new SIDataSetTableAdapters.P2_QueryTableAdapter();
                    SIDataSet.P2_QueryDataTable P2DataTable = new SIDataSet.P2_QueryDataTable();
                    P2TableAdapter.Fill(P2DataTable);
                    for (int i = 0; i < P2DataTable.Rows.Count; i++)
                    {
                        //DesiredProduct.Items.Add(P2DataTable.Rows[i]["P2"].ToString());
                        StoredData.Add(P2DataTable.Rows[i]["P2"].ToString());
                        StoredData.Add(P2DataTable.Rows[i]["Planets"].ToString());
                    }

                    PopulateDesiredProduct();
                }
                if (ResourceTier.SelectedIndex == 2) // Tier 3
                {
                    StoredData.Clear();
                    SIDataSetTableAdapters.P3TableAdapter P3TableAdapter = new SIDataSetTableAdapters.P3TableAdapter();
                    SIDataSet.P3DataTable P3DataTable = new SIDataSet.P3DataTable();
                    P3TableAdapter.Fill(P3DataTable);
                    for (int i = 0; i < P3DataTable.Rows.Count; i++)
                    {
                        //DesiredProduct.Items.Add(P3DataTable.Rows[i]["P3"].ToString());
                        StoredData.Add(P3DataTable.Rows[i]["P3"].ToString());
                        StoredData.Add(P3DataTable.Rows[i]["Planets"].ToString());
                    }

                    PopulateDesiredProduct();
                }
                if (ResourceTier.SelectedIndex == 3) // Tier 4
                {
                    SIDataSetTableAdapters.P4TableAdapter P4TableAdapter = new SIDataSetTableAdapters.P4TableAdapter();
                    SIDataSet.P4DataTable P4DataTable = new SIDataSet.P4DataTable();
                    P4TableAdapter.Fill(P4DataTable);
                    for (int i = 0; i < P4DataTable.Rows.Count; i++)
                    {
                        //DesiredProduct.Items.Add(P4DataTable.Rows[i]["P4"].ToString());
                        StoredData.Add(P4DataTable.Rows[i]["P4"].ToString());
                        StoredData.Add(P4DataTable.Rows[i]["Planets"].ToString());
                    }

                    PopulateDesiredProduct();
                }
            }

            // If database can't be accessed uses popup window form to display this error.
            catch (System.Data.OleDb.OleDbException)
            {
                Popup error = new Popup("Database Error", "A problem has occured while trying to access the database.");
                error.Show();
            }
        }
        // After a resource is chosen from the last combo-box make the next combobox visible.
        private void DesiredProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateUsingLabel.Visible = true;
            CalculateUsing.Visible = true;
        }
        // After you decide how you want to calculate the numbers from last combobox you make the final combo-box visible.
        private void CalculateUsing_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            Value.Visible = true;
            // Depending on the value in CalculateUsing it chooses which unit to show after the Vale Combo-box.
            if (CalculateUsing.SelectedIndex == 0) // Quantity 
            {
                MassLabel.Visible = false;
                QuantityUnits.Visible = true;
            }
            if (CalculateUsing.SelectedIndex == 1) // Maximum Volume
            {
                QuantityUnits.Visible = false;
                MassLabel.Visible = true;
            }
        }
        private void BuildResult_Click_1(object sender, EventArgs e)
        {
            try
            {
                String Quantity;
                int row = 0;
                Quantity = Value.Text;
                ResultsPanel.Controls.Clear();
                if (ResourceTier.SelectedIndex == 0) // Tier 1
                {
                    SIDataSetTableAdapters.P1_QueryTableAdapter P1TableAdapter = new SIDataSetTableAdapters.P1_QueryTableAdapter();
                    SIDataSet.P1_QueryDataTable P1DataTable = new SIDataSet.P1_QueryDataTable();
                    P1TableAdapter.Fill(P1DataTable);
                    List<String> P1Resources = new List<String>();
                    for (int i = 0; i < P1DataTable.Rows.Count; i++)
                    {
                        if (P1DataTable.Rows[i]["P1"].ToString().Equals(DesiredProduct.Text) == true)
                        {
                            row = i;
                            break;
                        }
                    }
                    for (int i = 0; i < P1DataTable.Columns.Count; i++)
                        P1Resources.Add(P1DataTable.Rows[row][i].ToString());
                    ResultsPanel.Controls.Add(new P1(P1Resources, CalculateUsing.SelectedIndex, Convert.ToDouble(Quantity)));
                }
                if (ResourceTier.SelectedIndex == 1) // Tier 2
                {
                    SIDataSetTableAdapters.P2_QueryTableAdapter P2TableAdapter = new SIDataSetTableAdapters.P2_QueryTableAdapter();
                    SIDataSet.P2_QueryDataTable P2DataTable = new SIDataSet.P2_QueryDataTable();
                    P2TableAdapter.Fill(P2DataTable);
                    List<String> P2Resources = new List<String>();
                    for (int i = 0; i < P2DataTable.Rows.Count; i++)
                    {
                        if (P2DataTable.Rows[i]["P2"].ToString().Equals(DesiredProduct.Text) == true)
                        {
                            row = i;
                            break;
                        }
                    }
                    for (int i = 0; i < P2DataTable.Columns.Count; i++)
                        P2Resources.Add(P2DataTable.Rows[row][i].ToString());
                    ResultsPanel.Controls.Add(new P2(P2Resources, CalculateUsing.SelectedIndex, Convert.ToDouble(Quantity)));
                }
                if (ResourceTier.SelectedIndex == 2) // Tier 3
                {
                    // If resource is one of the exceptions use different query.
                    if (DesiredProduct.Text == "Biotech Research Reports" || DesiredProduct.Text == "Cryoprotectant Solution" || DesiredProduct.Text == "Gel-Matrix Biopaste" || DesiredProduct.Text == "Hazmat Detection Systems" || DesiredProduct.Text == "Planetary Vehicles" || DesiredProduct.Text == "Supercomputers")
                    {
                        SIDataSetTableAdapters.P3_Query_3_P2TableAdapter P3TableAdapter = new SIDataSetTableAdapters.P3_Query_3_P2TableAdapter();
                        SIDataSet._P3_Query_3_P2DataTable P3DataTable = new SIDataSet._P3_Query_3_P2DataTable();
                        P3TableAdapter.Fill(P3DataTable);
                        List<String> P3Resources = new List<String>();
                        for (int i = 0; i < P3DataTable.Rows.Count; i++)
                        {
                            if (P3DataTable.Rows[i]["P3"].ToString().Equals(DesiredProduct.Text) == true)
                            {
                                row = i;
                                break;
                            }
                        }
                        for (int i = 1; i < P3DataTable.Columns.Count; i++)
                            P3Resources.Add(P3DataTable.Rows[row][i].ToString());
                        ResultsPanel.Controls.Add(new P3_3(P3Resources, CalculateUsing.SelectedIndex, Convert.ToDouble(Quantity)));
                    }
                    // Otherwise use standard tier 3 query.
                    else
                    {
                        SIDataSetTableAdapters.P3_QueryTableAdapter P3TableAdapter = new SIDataSetTableAdapters.P3_QueryTableAdapter();
                        SIDataSet.P3_QueryDataTable P3DataTable = new SIDataSet.P3_QueryDataTable();
                        P3TableAdapter.Fill(P3DataTable);
                        List<String> P3Resources = new List<String>();
                        for (int i = 0; i < P3DataTable.Rows.Count; i++)
                        {
                            if (P3DataTable.Rows[i]["P3"].ToString().Equals(DesiredProduct.Text) == true)
                            {
                                row = i;
                                break;
                            }
                        }
                        for (int i = 1; i < P3DataTable.Columns.Count; i++)
                            P3Resources.Add(P3DataTable.Rows[row][i].ToString());
                        ResultsPanel.Controls.Add(new P3_2(P3Resources, CalculateUsing.SelectedIndex, Convert.ToDouble(Quantity)));
                    }
                }
                if (ResourceTier.SelectedIndex == 3) // Tier 4
                {
                    if (DesiredProduct.Text == "Broadcast Node" || DesiredProduct.Text == "Recursive Computing Module" || DesiredProduct.Text == "Self Harmonizing Power Core")
                    {
                        SIDataSetTableAdapters.P4_Query_R1__2_P2_TableAdapter P4_R1TableAdapter = new SIDataSetTableAdapters.P4_Query_R1__2_P2_TableAdapter();
                        SIDataSet._P4_Query_R1__2_P2_DataTable P4_R1DataTable = new SIDataSet._P4_Query_R1__2_P2_DataTable();
                        P4_R1TableAdapter.Fill(P4_R1DataTable);
                        List<String> P4_R1 = new List<String>();
                        for (int i = 0; i < P4_R1DataTable.Rows.Count; i++)
                        {
                            if (P4_R1DataTable.Rows[i]["P4"].ToString().Equals(DesiredProduct.Text) == true)
                            {
                                row = i;
                                break;
                            }
                        }
                        for (int i = 0; i < P4_R1DataTable.Columns.Count; i++)
                            P4_R1.Add(P4_R1DataTable.Rows[row][i].ToString());

                        SIDataSetTableAdapters.P4_Query_R2__2_P2_TableAdapter P4_R2TableAdapter = new SIDataSetTableAdapters.P4_Query_R2__2_P2_TableAdapter();
                        SIDataSet._P4_Query_R2__2_P2_DataTable P4_R2DataTable = new SIDataSet._P4_Query_R2__2_P2_DataTable();
                        P4_R2TableAdapter.Fill(P4_R2DataTable);
                        List<String> P4_R2 = new List<String>();
                        for (int i = 0; i < P4_R2DataTable.Rows.Count; i++)
                        {
                            if (P4_R2DataTable.Rows[i]["P4"].ToString().Equals(DesiredProduct.Text) == true)
                            {
                                row = i;
                                break;
                            }
                        }
                        for (int i = 0; i < P4_R2DataTable.Columns.Count; i++)
                            P4_R2.Add(P4_R2DataTable.Rows[row][i].ToString());

                        SIDataSetTableAdapters.P4_Query_R3__2_P2_TableAdapter P4_R3TableAdapter = new SIDataSetTableAdapters.P4_Query_R3__2_P2_TableAdapter();
                        SIDataSet._P4_Query_R3__2_P2_DataTable P4_R3DataTable = new SIDataSet._P4_Query_R3__2_P2_DataTable();
                        P4_R3TableAdapter.Fill(P4_R3DataTable);
                        List<String> P4_R3 = new List<String>();
                        for (int i = 0; i < P4_R3DataTable.Rows.Count; i++)
                        {
                            if (P4_R3DataTable.Rows[i]["P4"].ToString().Equals(DesiredProduct.Text) == true)
                            {
                                row = i;
                                break;
                            }
                        }
                        for (int i = 0; i < P4_R3DataTable.Columns.Count; i++)
                            P4_R3.Add(P4_R3DataTable.Rows[row][i].ToString());

                        ResultsPanel.Controls.Add(new P4_P3_2(P4_R1, P4_R2, P4_R3, CalculateUsing.SelectedIndex, Convert.ToDouble(Quantity)));
                    }
                    else if (DesiredProduct.Text == "Integrity Response Drones" || DesiredProduct.Text == "Wetware Mainframe")
                    {
                        SIDataSetTableAdapters.P4_Query_R1__3_P2_TableAdapter P4_R1TableAdapter = new SIDataSetTableAdapters.P4_Query_R1__3_P2_TableAdapter();
                        SIDataSet._P4_Query_R1__3_P2_DataTable P4_R1DataTable = new SIDataSet._P4_Query_R1__3_P2_DataTable();
                        P4_R1TableAdapter.Fill(P4_R1DataTable);
                        List<String> P4_R1 = new List<String>();
                        for (int i = 0; i < P4_R1DataTable.Rows.Count; i++)
                        {
                            if (P4_R1DataTable.Rows[i]["P4"].ToString().Equals(DesiredProduct.Text) == true)
                            {
                                row = i;
                                break;
                            }
                        }
                        for (int i = 0; i < P4_R1DataTable.Columns.Count; i++)
                            P4_R1.Add(P4_R1DataTable.Rows[row][i].ToString());

                        SIDataSetTableAdapters.P4_Query_R2__3_P2_TableAdapter P4_R2TableAdapter = new SIDataSetTableAdapters.P4_Query_R2__3_P2_TableAdapter();
                        SIDataSet._P4_Query_R2__3_P2_DataTable P4_R2DataTable = new SIDataSet._P4_Query_R2__3_P2_DataTable();
                        P4_R2TableAdapter.Fill(P4_R2DataTable);
                        List<String> P4_R2 = new List<String>();
                        for (int i = 0; i < P4_R2DataTable.Rows.Count; i++)
                        {
                            if (P4_R2DataTable.Rows[i]["P4"].ToString().Equals(DesiredProduct.Text) == true)
                            {
                                row = i;
                                break;
                            }
                        }
                        for (int i = 0; i < P4_R2DataTable.Columns.Count; i++)
                            P4_R2.Add(P4_R2DataTable.Rows[row][i].ToString());

                        SIDataSetTableAdapters.P4_Query_R3__3_P2_TableAdapter P4_R3TableAdapters = new SIDataSetTableAdapters.P4_Query_R3__3_P2_TableAdapter();
                        SIDataSet._P4_Query_R3__3_P2_DataTable P4_R3DataTable = new SIDataSet._P4_Query_R3__3_P2_DataTable();
                        P4_R3TableAdapters.Fill(P4_R3DataTable);
                        List<String> P4_R3 = new List<String>();
                        for (int i = 0; i < P4_R3DataTable.Rows.Count; i++)
                        {
                            if (P4_R3DataTable.Rows[i]["P4"].ToString().Equals(DesiredProduct.Text) == true)
                            {
                                row = i;
                                break;
                            }
                        }
                        for (int i = 0; i < P4_R3DataTable.Columns.Count; i++)
                            P4_R3.Add(P4_R3DataTable.Rows[row][i].ToString());

                        ResultsPanel.Controls.Add(new P4_P3_3(P4_R1, P4_R2, P4_R3, CalculateUsing.SelectedIndex, Convert.ToDouble(Quantity)));
                    }
                    else
                    {
                        SIDataSetTableAdapters.P4_Query_R1__2_P2_TableAdapter P4_R1TableAdapter = new SIDataSetTableAdapters.P4_Query_R1__2_P2_TableAdapter();
                        SIDataSet._P4_Query_R1__2_P2_DataTable P4_R1DataTable = new SIDataSet._P4_Query_R1__2_P2_DataTable();
                        P4_R1TableAdapter.Fill(P4_R1DataTable);
                        List<String> P4_R1 = new List<String>();
                        for (int i = 0; i < P4_R1DataTable.Rows.Count; i++)
                        {
                            if (P4_R1DataTable.Rows[i]["P4"].ToString().Equals(DesiredProduct.Text) == true)
                            {
                                row = i;
                                break;
                            }
                        }
                        for (int i = 0; i < P4_R1DataTable.Columns.Count; i++)
                            P4_R1.Add(P4_R1DataTable.Rows[row][i].ToString());

                        SIDataSetTableAdapters.P4_Query_R2__2_P2_TableAdapter P4_R2TableAdapter = new SIDataSetTableAdapters.P4_Query_R2__2_P2_TableAdapter();
                        SIDataSet._P4_Query_R2__2_P2_DataTable P4_R2DataTable = new SIDataSet._P4_Query_R2__2_P2_DataTable();
                        P4_R2TableAdapter.Fill(P4_R2DataTable);
                        List<String> P4_R2 = new List<String>();
                        for (int i = 0; i < P4_R2DataTable.Rows.Count; i++)
                        {
                            if (P4_R2DataTable.Rows[i]["P4"].ToString().Equals(DesiredProduct.Text) == true)
                            {
                                row = i;
                                break;
                            }
                        }
                        for (int i = 0; i < P4_R2DataTable.Columns.Count; i++)
                            P4_R2.Add(P4_R2DataTable.Rows[row][i].ToString());

                        SIDataSetTableAdapters.P4_Query_R3__P1_TableAdapter P4_R3TableAdapter = new SIDataSetTableAdapters.P4_Query_R3__P1_TableAdapter();
                        SIDataSet._P4_Query_R3__P1_DataTable P4_R3DataTable = new SIDataSet._P4_Query_R3__P1_DataTable();
                        P4_R3TableAdapter.Fill(P4_R3DataTable);
                        List<String> P4_R3 = new List<String>();
                        for (int i = 0; i < P4_R3DataTable.Rows.Count; i++)
                        {
                            if (P4_R3DataTable.Rows[i]["P4"].ToString().Equals(DesiredProduct.Text) == true)
                            {
                                row = i;
                                break;
                            }
                        }
                        for (int i = 0; i < P4_R3DataTable.Columns.Count; i++)
                            P4_R3.Add(P4_R3DataTable.Rows[row][i].ToString());

                        ResultsPanel.Controls.Add(new P4_P1(P4_R1, P4_R2, P4_R3, CalculateUsing.SelectedIndex, Convert.ToDouble(Quantity)));
                    }
                }
            }
            // Error popup occurs when user hasn't selected a value for all 4 combo-boxes.
            catch (System.FormatException)
            {
                Popup error = new Popup("Format Exception", "There has been a problem Calculating your request. Are you sure you have filled in the Tier, Resource, and Quantity?");
                error.Show();
            }
            // Error popup occurs when user changes the tier but doesn't change the resource they want.
            catch (System.IndexOutOfRangeException)
            {
                Popup error = new Popup("Index Error", "When you changed the tier you didn't change the desired product!");
                error.Show();
            }
        }

        // Function used to decide what resource to put in the DesiredProduct Combobox based on the planets that are selected
        public void PopulateDesiredProduct()
        {
            try
            {
                List<Boolean> CheckAll = new List<Boolean>();
                for (int i = 1; i < StoredData.Capacity; i += 2)
                {
                    if (StoredData[i].Contains('+') == true)
                    {
                        CheckAll.Clear();
                        String[] MultiPlanets = StoredData[i].Split('+');
                        Boolean needCheck = new Boolean();
                        for (int l = 0; l < MultiPlanets.Length; l++)
                        {
                            if (MultiPlanets[l].Length > 1)
                                needCheck = true;
                        }
                        if (needCheck == true)
                        {
                            for (int j = 0; j < MultiPlanets.Length; j++)
                            {
                                
                                String[] From = MultiPlanets[j].Split(',');
                                List<Boolean> CheckEach = new List<Boolean>();
                                for (int m = 0; m < From.Length; m++)
                                {
                                    for (int n = 0; n < Planets.Count; n++)
                                    {
                                        if (From[m].Equals(Planets[n]) == true)
                                        {
                                            if (PlanetToggles[n] == true)
                                                CheckEach.Add(true);
                                            else
                                                CheckEach.Add(false);
                                        }
                                    }
                                }
                                if (CheckEach.Contains(true) == true)
                                    CheckAll.Add(true);
                                else
                                    CheckAll.Add(false);
                            }
                        }
                        else
                        {
                            for (int m = 0; m < MultiPlanets.Length; m++)
                            {
                                for (int n = 0; n < Planets.Count; n++)
                                {
                                    if (MultiPlanets[m].Equals(Planets[n]) == true)
                                    {
                                        if (PlanetToggles[n] == true)
                                            CheckAll.Add(true);
                                        else
                                            CheckAll.Add(false);
                                    }
                                }
                            }
                        }
                        if (CheckAll.Contains(false) == false)
                        {
                            if (DesiredProduct.FindStringExact(StoredData[i - 1]) == -1)
                                DesiredProduct.Items.Add(StoredData[i - 1]);
                        }
                    }
                    else
                    {
                        String[] From = StoredData[i].Split(',');
                        for (int k = 0; k < From.Length; k++)
                        {
                            for (int j = 0; j < Planets.Count; j++)
                            {
                                if ((From[k] == Planets[j]) && (PlanetToggles[j] == true))
                                {
                                    if (DesiredProduct.FindStringExact(StoredData[i - 1]) == -1)
                                        DesiredProduct.Items.Add(StoredData[i - 1]);
                                }
                            }
                        }
                    }
                }
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void ResourceTier_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}