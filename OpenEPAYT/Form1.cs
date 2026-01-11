using DotSpatial.Controls;
using OpenEPAYT.Network;
using OpenEPAYT.Network.Components;
using System.Globalization;

namespace OpenEPAYT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region DEFINIÇÃO DE CULTURA PARA PADRÃO INGLÊS (EUA)
            CultureInfo culture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            // Opcional: Para aplicativos .NET Core/5+
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            #endregion

        }

        private void BTOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog JanelaAbrir = new OpenFileDialog();
            JanelaAbrir.Filter = "Shapefile File (*.shp)|*.shp";
            JanelaAbrir.Title = "Open file";
            if (JanelaAbrir.ShowDialog() == DialogResult.OK)
            {
                string shapefilePath = JanelaAbrir.FileName;
                var layer = DotSpatial.Data.Shapefile.Open(shapefilePath);
                IMapLayer LayerAdicionado = MapViewer.Layers.Add(layer);
                MapViewer.ZoomToMaxExtent();
            }
            // ATIVAÇÃO DA FERRAMENTA DE SELEÇÃO E ZOOM
            MapViewer.FunctionMode = DotSpatial.Controls.FunctionMode.Pan;
        }

        #region EVENTOS DO MAPA 
        private void MapViewer_GeoMouseMove(object sender, DotSpatial.Controls.GeoMouseArgs e)
        {
            if (e.GeographicLocation != null)
            {
                LBCoordinates.Text = $"X: {e.GeographicLocation.X:F6}, Y: {e.GeographicLocation.Y:F6}";
            }
        }
        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
