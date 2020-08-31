using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Controllers;
using GestaoFinanceira.Model;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmListCategories : Form
    {
        public Category categorie;
        CategoriesController ctr = new CategoriesController();

        public FrmListCategories()
        {
            InitializeComponent();
            this.ctr = new CategoriesController();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            string description = "";
            if (tvCategories.SelectedNode.Level == 0)
            {
                description = "Nova Categoria";
            }
            else
            if (tvCategories.SelectedNode.Tag is Category)
            {
                description = "Nova Subcategoria";
            }
            var node = tvCategories.SelectedNode.Nodes.Add(description);

            tvCategories.LabelEdit = true;
            node.EnsureVisible();

            node.BeginEdit();

        }
        private void tvCategories_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Label))
            {
                if (e.Node.Parent.Level == 0)
                {
                    var cat = e.Node.Tag as Category ?? new Category()
                    {
                        SubCategories = new List<SubCategories>(),
                        type = (GestaoFinanceira.Enums.EntryType)tvCategories.SelectedNode.Tag
                    };
                    cat.Description = e.Label;
                    ctr.Save(cat);
                    if (e.Node.Tag is null)
                        e.Node.Tag = cat;
                }
                else
                if (e.Node.Parent.Tag is Category)
                {
                    var cat = (e.Node.Parent.Tag as Category);
                    var subCat = e.Node.Tag as SubCategories ?? new SubCategories();

                    subCat.Description = e.Label;
                    cat.SubCategories.Add(subCat);
                    ctr.Save(cat);
                    if (e.Node.Tag is null)
                        e.Node.Tag = subCat;

                }

            }
            else if (e.Node.Tag == null)
            {
                e.Node.Parent.Nodes.Remove(e.Node);
            }
            tvCategories.LabelEdit = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja apagar?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && tvCategories.SelectedNode != null)
                {
                    var node = tvCategories.SelectedNode;
                    if (node.Tag is Category)
                    {
                        Category removCat = node.Tag as Category;
                        ctr.Remove(removCat);
                    }
                    else if(node.Tag is SubCategories)
                    {
                        var cat = node.Parent.Tag as Category;
                        var subCategorie = node.Tag as SubCategories;
                        cat.SubCategories.Remove(subCategorie);
                        ctr.Save(cat);
                    }
                        tvCategories.SelectedNode.Parent.Nodes.Remove(node);
                }
            }
            catch (Exception msg)
            {

            }
        }

        private void lbCategories_Paint(object sender, PaintEventArgs e)
        {
            Font myFont = new Font("Microsoft PhagsPa", 16, FontStyle.Bold);
            Brush myBrush = new SolidBrush(Color.Black);
            e.Graphics.TranslateTransform(6, 125);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("Categorias", myFont, myBrush, 0, 0);
        }
        private void FrmListCategories_Load(object sender, EventArgs e)
        {
            pnCategories.BackColor = SystemColors.BLUE;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                tvCategories.LabelEdit = true;
                tvCategories.SelectedNode.BeginEdit();

            }
            catch (Exception msg)
            {

            }
        }

        private void FrmListCategories_Shown(object sender, EventArgs e)
        {
            ctr.LoadTreeView(tvCategories);
        }

        private void tvCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvCategories.SelectedNode != null)
            {
                if (tvCategories.SelectedNode.Tag is SubCategories || tvCategories.SelectedNode.Tag is Category)
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
        }
    }
}
