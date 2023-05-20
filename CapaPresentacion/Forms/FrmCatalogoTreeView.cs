using CapaEntidades;
using CapaNegocios;
using System;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FrmCatalogoTreeView : Form
    {
        readonly CN_Grupos grupos = new CN_Grupos();
        readonly CN_Subgrupos subgrupos = new CN_Subgrupos();
        readonly CN_Mayor mayor = new CN_Mayor();

        public FrmCatalogoTreeView()
        {
            InitializeComponent();
        }

        private void FrmCatalogoTreeView_Load(object sender, EventArgs e)
        {
            var NdRoot = CatalogoTreeView.Nodes.Add("Catalogo");
            var Grp = grupos.ListarGrupos();
            foreach (Grupos grupo in Grp)
            {
                var NdGrupo = NdRoot.Nodes.Add(grupo.Cuenta);
                var Sub = subgrupos.ListarSubgrupos(grupo.IDGrupo);
                foreach (Subgrupos subgrupo in Sub)
                {
                    var NdSubGrupo = NdGrupo.Nodes.Add(subgrupo.Cuenta);
                    var may = mayor.ListarMayor(subgrupo.IDSubgrupo);
                    foreach (Mayor mayor in may)
                    {
                        var NdMay = NdSubGrupo.Nodes.Add(mayor.Cuenta);
                    }
                }
            }
        }
    }
}
