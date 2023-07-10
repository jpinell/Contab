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
            NdRoot.Tag = "R|0";
            NdRoot.Nodes.Add("Temporal");

            //var Grp = grupos.ListarGrupos();
            //foreach (Grupos grupo in Grp)
            //{
            //    var NdGrupo = NdRoot.Nodes.Add(grupo.Cuenta);
            //    var Sub = subgrupos.ListarSubgrupos(grupo.IDGrupo);
            //    foreach (Subgrupos subgrupo in Sub)
            //    {
            //        var NdSubGrupo = NdGrupo.Nodes.Add(subgrupo.Cuenta);
            //        var may = mayor.ListarMayor(subgrupo.IDSubgrupo);
            //        foreach (Mayor mayor in may)
            //        {
            //            var NdMay = NdSubGrupo.Nodes.Add(mayor.Cuenta);

            //        }
            //    }
            //}
        }

        private void CatalogoTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] key = e.Node.Tag.ToString().Split('|');
            switch (key[0])
            {
                case "R":
                    var Grp = grupos.ListarGrupos();
                    foreach (Grupos grupo in Grp)
                    {
                        var NdGrupo = e.Node.Nodes.Add(grupo.Cuenta);
                        NdGrupo.Tag = "G|" + grupo.IDGrupo.ToString();
                        NdGrupo.Nodes.Add("Temporal"); 
                    }
                    break;
                case "G":
                    var SubGrp = subgrupos.ListarSubgrupos(Convert.ToInt32(key[1]));
                    foreach (Subgrupos subgrupo in SubGrp)
                    {
                        var NdSubGrupo = e.Node.Nodes.Add(subgrupo.Cuenta);
                        NdSubGrupo.Tag = "S|" + subgrupo.IDSubgrupo.ToString();
                        NdSubGrupo.Nodes.Add("Temporal");
                    }
                    break;
                case "S":
                    var may = mayor.ListarMayor(Convert.ToInt32(key[1]));
                    foreach (Mayor mayor in may)
                    {
                        var NdMayor = e.Node.Nodes.Add(mayor.Cuenta);
                        NdMayor.Tag = "M|" + mayor.IDMayor.ToString();

                    }
                    break;
            }
        }

        private void CatalogoTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show("Has pulsado en " + "\n" + e.Node.ToString());
            MessageBox.Show("Has pulsado en " + "\n" + e.Node.Text + " " + e.Node.Tag);
        }
    }
}
