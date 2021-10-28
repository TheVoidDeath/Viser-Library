using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVP_P2_NRT57_18_REMAKE.sln.KnjizaraDataSetTableAdapters;
using TVP_P2_NRT57_18_REMAKE.sln.Properties;

namespace TVP_P2_NRT57_18_REMAKE.sln
{
    public partial class Form1 : Form
    {
        #region Standard

        #region init Decl
        private System.Windows.Forms.ComboBox Genre_Box;
        private System.Windows.Forms.ComboBox Author_Box;
        private System.Windows.Forms.ComboBox Book_Boox;
        private System.Windows.Forms.Button Add_Book;
        private System.Windows.Forms.Button Racuni_Check;
        private System.Windows.Forms.Button To_Basket_Btn;
        private System.Windows.Forms.Button Del_Selected;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Pay_Btn;
        private System.Windows.Forms.TextBox Search_By_x_TB;
        private System.Windows.Forms.TextBox Volume_TB;
        private System.Windows.Forms.GroupBox Standard_Group;
        private System.Windows.Forms.Label Book_LBL;
        private System.Windows.Forms.Label Author_LBL;
        private System.Windows.Forms.Label Genre_LBL;
        private System.Windows.Forms.ListBox Basket;
        private System.Windows.Forms.GroupBox Fancy_Group;
        private System.Windows.Forms.ListBox Search_Results;
        private System.Windows.Forms.Button by_Book_Name;
        private System.Windows.Forms.Button by_Author_Name;
        private System.Windows.Forms.Label Volume_Label;
        private System.Windows.Forms.Label racun_Label;
        #endregion

        private void Init()
        {
            this.Genre_Box = new System.Windows.Forms.ComboBox();
            this.Author_Box = new System.Windows.Forms.ComboBox();
            this.Book_Boox = new System.Windows.Forms.ComboBox();
            this.Add_Book = new System.Windows.Forms.Button();
            this.Racuni_Check = new System.Windows.Forms.Button();
            this.To_Basket_Btn = new System.Windows.Forms.Button();
            this.Del_Selected = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Pay_Btn = new System.Windows.Forms.Button();
            this.Search_By_x_TB = new System.Windows.Forms.TextBox();
            this.Volume_TB = new System.Windows.Forms.TextBox();
            this.Standard_Group = new System.Windows.Forms.GroupBox();
            this.Basket = new System.Windows.Forms.ListBox();
            this.Fancy_Group = new System.Windows.Forms.GroupBox();
            this.by_Book_Name = new System.Windows.Forms.Button();
            this.by_Author_Name = new System.Windows.Forms.Button();
            this.Search_Results = new System.Windows.Forms.ListBox();
            this.Volume_Label = new System.Windows.Forms.Label();
            this.Genre_LBL = new System.Windows.Forms.Label();
            this.Author_LBL = new System.Windows.Forms.Label();
            this.Book_LBL = new System.Windows.Forms.Label();
            this.racun_Label = new System.Windows.Forms.Label();
            this.Standard_Group.SuspendLayout();
            this.Fancy_Group.SuspendLayout();
        }
        private void Standard()
        {
            this.SuspendLayout();
            // 
            // Genre_Box
            // 
            this.Genre_Box.FormattingEnabled = true;
            this.Genre_Box.Location = new System.Drawing.Point(36, 79);
            this.Genre_Box.Name = "Genre_Box";
            this.Genre_Box.Size = new System.Drawing.Size(121, 21);
            this.Genre_Box.TabIndex = 0;
            this.Genre_Box.SelectedIndexChanged += new System.EventHandler(this.Genre_Box_SelectedIndexChanged);
            this.Genre_Box.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // Author_Box
            // 
            this.Author_Box.FormattingEnabled = true;
            this.Author_Box.Location = new System.Drawing.Point(223, 79);
            this.Author_Box.Name = "Author_Box";
            this.Author_Box.Size = new System.Drawing.Size(121, 21);
            this.Author_Box.TabIndex = 1;
            this.Author_Box.SelectedIndexChanged += new System.EventHandler(this.Author_Box_SelectedIndexChanged);
            this.Author_Box.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // Book_Boox
            // 
            this.Book_Boox.FormattingEnabled = true;
            this.Book_Boox.Location = new System.Drawing.Point(126, 218);
            this.Book_Boox.Name = "Book_Boox";
            this.Book_Boox.Size = new System.Drawing.Size(121, 21);
            this.Book_Boox.TabIndex = 2;
            this.Book_Boox.SelectedIndexChanged += new System.EventHandler(this.Book_Boox_SelectedIndexChanged);
            this.Book_Boox.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // Add_Book
            // 
            this.Add_Book.Location = new System.Drawing.Point(12, 12);
            this.Add_Book.Name = "Add_Book";
            this.Add_Book.Size = new System.Drawing.Size(378, 23);
            this.Add_Book.TabIndex = 3;
            this.Add_Book.Text = "(ADMINISTRATOR) Dodavanje Knjiga u Bazu";
            this.Add_Book.UseVisualStyleBackColor = true;
            this.Add_Book.Click += new System.EventHandler(this.Add_Book_Click);
            // 
            // Racuni_Check
            // 
            this.Racuni_Check.Location = new System.Drawing.Point(424, 12);
            this.Racuni_Check.Name = "Racuni_Check";
            this.Racuni_Check.Size = new System.Drawing.Size(384, 23);
            this.Racuni_Check.TabIndex = 4;
            this.Racuni_Check.Text = "(ADMINISTRATOR) Pregled Racuna";
            this.Racuni_Check.UseVisualStyleBackColor = true;
            this.Racuni_Check.Click += new System.EventHandler(this.Racuni_Check_Click);
            // 
            // To_Basket_Btn
            // 
            this.To_Basket_Btn.Location = new System.Drawing.Point(289, 402);
            this.To_Basket_Btn.Name = "To_Basket_Btn";
            this.To_Basket_Btn.Size = new System.Drawing.Size(145, 55);
            this.To_Basket_Btn.TabIndex = 5;
            this.To_Basket_Btn.Text = "Dodajte zeljenu knjigu u korpu";
            this.To_Basket_Btn.UseVisualStyleBackColor = true;
            this.To_Basket_Btn.Click += new System.EventHandler(this.To_Basket_Btn_Click);
            // 
            // Del_Selected
            // 
            this.Del_Selected.Location = new System.Drawing.Point(492, 402);
            this.Del_Selected.Name = "Del_Selected";
            this.Del_Selected.Size = new System.Drawing.Size(210, 23);
            this.Del_Selected.TabIndex = 6;
            this.Del_Selected.Text = "Uklonite selektovanu knjigu iz korpe";
            this.Del_Selected.UseVisualStyleBackColor = true;
            this.Del_Selected.Click += new System.EventHandler(this.Del_Selected_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(492, 434);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(210, 23);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Ispraznite Korpu";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Pay_Btn
            // 
            this.Pay_Btn.Location = new System.Drawing.Point(276, 564);
            this.Pay_Btn.Name = "Pay_Btn";
            this.Pay_Btn.Size = new System.Drawing.Size(279, 60);
            this.Pay_Btn.TabIndex = 8;
            this.Pay_Btn.Text = "Placanje stvari iz korpe";
            this.Pay_Btn.UseVisualStyleBackColor = true;
            this.Pay_Btn.Click += new System.EventHandler(this.Pay_Btn_Click);
            // 
            // Search_By_x_TB
            // 
            this.Search_By_x_TB.Location = new System.Drawing.Point(42, 50);
            this.Search_By_x_TB.Name = "Search_By_x_TB";
            this.Search_By_x_TB.Size = new System.Drawing.Size(309, 20);
            this.Search_By_x_TB.TabIndex = 9;
            // 
            // Volume_TB
            // 
            this.Volume_TB.Location = new System.Drawing.Point(192, 420);
            this.Volume_TB.Name = "Volume_TB";
            this.Volume_TB.Size = new System.Drawing.Size(58, 20);
            this.Volume_TB.TabIndex = 10;
            this.Volume_TB.Text = "1";
            // 
            // Standard_Group
            // 
            this.Standard_Group.Controls.Add(this.Book_LBL);
            this.Standard_Group.Controls.Add(this.Author_LBL);
            this.Standard_Group.Controls.Add(this.Genre_LBL);
            this.Standard_Group.Controls.Add(this.Book_Boox);
            this.Standard_Group.Controls.Add(this.Author_Box);
            this.Standard_Group.Controls.Add(this.Genre_Box);
            this.Standard_Group.Location = new System.Drawing.Point(12, 60);
            this.Standard_Group.Name = "Standard_Group";
            this.Standard_Group.Size = new System.Drawing.Size(370, 304);
            this.Standard_Group.TabIndex = 11;
            this.Standard_Group.TabStop = false;
            this.Standard_Group.Text = "Dodavanje knjiga po zadatim filterima";
            // 
            // Book_LBL
            // 
            this.Book_LBL.AutoSize = true;
            this.Book_LBL.Location = new System.Drawing.Point(123, 188);
            this.Book_LBL.Name = "Book_LBL";
            this.Book_LBL.Size = new System.Drawing.Size(128, 13);
            this.Book_LBL.TabIndex = 16;
            this.Book_LBL.Text = "Knjige po gornjim Filterima";
            // 
            // Author_LBL
            // 
            this.Author_LBL.AutoSize = true;
            this.Author_LBL.Location = new System.Drawing.Point(274, 53);
            this.Author_LBL.Name = "Author_LBL";
            this.Author_LBL.Size = new System.Drawing.Size(32, 13);
            this.Author_LBL.TabIndex = 15;
            this.Author_LBL.Text = "Autor";
            // 
            // Genre_LBL
            // 
            this.Genre_LBL.AutoSize = true;
            this.Genre_LBL.Location = new System.Drawing.Point(77, 53);
            this.Genre_LBL.Name = "Genre_LBL";
            this.Genre_LBL.Size = new System.Drawing.Size(29, 13);
            this.Genre_LBL.TabIndex = 14;
            this.Genre_LBL.Text = "Zanr";
            // 
            // Basket
            // 
            this.Basket.FormattingEnabled = true;
            this.Basket.Location = new System.Drawing.Point(12, 463);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(796, 95);
            this.Basket.TabIndex = 12;
            // 
            // Fancy_Group
            // 
            this.Fancy_Group.Controls.Add(this.Search_Results);
            this.Fancy_Group.Controls.Add(this.by_Book_Name);
            this.Fancy_Group.Controls.Add(this.by_Author_Name);
            this.Fancy_Group.Controls.Add(this.Search_By_x_TB);
            this.Fancy_Group.Location = new System.Drawing.Point(413, 60);
            this.Fancy_Group.Name = "Fancy_Group";
            this.Fancy_Group.Size = new System.Drawing.Size(395, 304);
            this.Fancy_Group.TabIndex = 3;
            this.Fancy_Group.TabStop = false;
            this.Fancy_Group.Text = "Dodavanje knjiga po imenima (Knjiga/Autora)";
            // 
            // Search_Results
            // 
            this.Search_Results.HorizontalScrollbar = true;
            this.Search_Results.FormattingEnabled = true;
            this.Search_Results.Location = new System.Drawing.Point(11, 164);
            this.Search_Results.Name = "Search_Results";
            this.Search_Results.Size = new System.Drawing.Size(378, 134);
            this.Search_Results.TabIndex = 15;
            this.Search_Results.SelectedIndexChanged += new System.EventHandler(this.Search_Results_SelectedIndexChanged);
            // 
            // by_Book_Name
            // 
            this.by_Book_Name.Location = new System.Drawing.Point(11, 108);
            this.by_Book_Name.Name = "by_Book_Name";
            this.by_Book_Name.Size = new System.Drawing.Size(171, 23);
            this.by_Book_Name.TabIndex = 13;
            this.by_Book_Name.Text = "Pretrazite po imenu knjige";
            this.by_Book_Name.UseVisualStyleBackColor = true;
            this.by_Book_Name.Click += new System.EventHandler(this.by_Book_Name_Click);
            // 
            // by_Author_Name
            // 
            this.by_Author_Name.Location = new System.Drawing.Point(226, 108);
            this.by_Author_Name.Name = "by_Author_Name";
            this.by_Author_Name.Size = new System.Drawing.Size(163, 23);
            this.by_Author_Name.TabIndex = 14;
            this.by_Author_Name.Text = "Pretrazite po imenu Autora";
            this.by_Author_Name.UseVisualStyleBackColor = true;
            this.by_Author_Name.Click += new System.EventHandler(this.by_Author_Name_Click);
            // 
            // Volume_Label
            // 
            this.Volume_Label.AutoSize = true;
            this.Volume_Label.Location = new System.Drawing.Point(59, 423);
            this.Volume_Label.Name = "Volume_Label";
            this.Volume_Label.Size = new System.Drawing.Size(110, 13);
            this.Volume_Label.TabIndex = 13;
            this.Volume_Label.Text = "Koliko Komada Zelite:";
            // 
            // racun_Label
            // 
            this.racun_Label.AutoSize = true;
            this.racun_Label.Location = new System.Drawing.Point(70, 588);
            this.racun_Label.Name = "racun_Label";
            this.racun_Label.Size = new System.Drawing.Size(132, 13);
            this.racun_Label.TabIndex = 14;
            this.racun_Label.Text = "Ukupan iznos za placanje:";
        }

        private void Standard_Add()
        {
            this.Controls.Add(this.racun_Label);
            this.Controls.Add(this.Volume_Label);
            this.Controls.Add(this.Fancy_Group);
            this.Controls.Add(this.Basket);
            this.Controls.Add(this.Standard_Group);
            this.Controls.Add(this.Volume_TB);
            this.Controls.Add(this.Pay_Btn);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Del_Selected);
            this.Controls.Add(this.To_Basket_Btn);
            this.Controls.Add(this.Racuni_Check);
            this.Controls.Add(this.Add_Book);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 636);
            this.Standard_Group.ResumeLayout(false);
            this.Standard_Group.PerformLayout();
            this.Fancy_Group.ResumeLayout(false);
            this.Fancy_Group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        #region Admin Look


        private System.Windows.Forms.TextBox pass_Box;
        private System.Windows.Forms.Button pass_check;
        private System.Windows.Forms.Label pass_LBL;
        private System.Windows.Forms.Button Back_Button;

        private void Admin_Check_Set_Proporties()
        {
            this.pass_Box = new System.Windows.Forms.TextBox();
            this.pass_check = new System.Windows.Forms.Button();
            this.pass_LBL = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pass_Box
            // 
            this.pass_Box.Location = new System.Drawing.Point(80, 108);
            this.pass_Box.Name = "pass_Box";
            this.pass_Box.Size = new System.Drawing.Size(185, 20);
            this.pass_Box.TabIndex = 0;
            // 
            // button1
            // 
            this.pass_check.Location = new System.Drawing.Point(150, 148);
            this.pass_check.Name = "pass_check";
            this.pass_check.Size = new System.Drawing.Size(75, 23);
            this.pass_check.TabIndex = 1;
            this.pass_check.Text = "Provera Sifre";
            this.pass_check.UseVisualStyleBackColor = true;
            this.pass_check.Click += new System.EventHandler(this.pass_check_Click);
            // 
            // pass_LBL
            // 
            this.pass_LBL.AutoSize = true;
            this.pass_LBL.Location = new System.Drawing.Point(100, 82);
            this.pass_LBL.Name = "pass_LBL";
            this.pass_LBL.Size = new System.Drawing.Size(147, 13);
            this.pass_LBL.TabIndex = 2;
            this.pass_LBL.Text = "Unesite Administratorsku Sifru";
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(130, 191);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(119, 35);
            this.Back_Button.TabIndex = 3;
            this.Back_Button.Text = "Povratak na glavnu stranu";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
        }

        private void Admin_Check_Add()
        {

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 275);
            //admi shit
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.pass_LBL);
            this.Controls.Add(this.pass_check);
            this.Controls.Add(this.pass_Box);


            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        #region Adding Books Look

        #region Control Declaration

        private KnjizaraDataSet knjizaraDataSet;
        private System.Windows.Forms.BindingSource knjigaBindingSource;
        private KnjizaraDataSetTableAdapters.KnjigaTableAdapter knjigaTableAdapter;
        private KnjizaraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator knjigaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton knjigaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.TextBox popustTextBox;
        private System.Windows.Forms.ComboBox id_kategorijaComboBox;
        private System.Windows.Forms.Button Back_Admin_Passed;
        System.Windows.Forms.Label nazivLabel;
        System.Windows.Forms.Label autorLabel;
        System.Windows.Forms.Label cenaLabel;
        System.Windows.Forms.Label popustLabel;
        System.Windows.Forms.Label id_kategorijaLabel;


        #endregion

        private void Init_Add_Book_Page()
        {

            this.components = new System.ComponentModel.Container();
            this.knjizaraDataSet = new KnjizaraDataSet();
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjigaTableAdapter = new KnjizaraDataSetTableAdapters.KnjigaTableAdapter();
            this.tableAdapterManager = new KnjizaraDataSetTableAdapters.TableAdapterManager();
            this.knjigaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.knjigaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.popustTextBox = new System.Windows.Forms.TextBox();
            this.id_kategorijaComboBox = new System.Windows.Forms.ComboBox();
            this.Back_Admin_Passed = new System.Windows.Forms.Button();
            nazivLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            popustLabel = new System.Windows.Forms.Label();
            id_kategorijaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.knjizaraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingNavigator)).BeginInit();
            this.knjigaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
        }

        private void Adding_Books()
        {
                        // 
            // knjizaraDataSet
            // 
            this.knjizaraDataSet.DataSetName = "KnjizaraDataSet";
            this.knjizaraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knjigaBindingSource
            // 
            this.knjigaBindingSource.DataMember = "Knjiga";
            this.knjigaBindingSource.DataSource = this.knjizaraDataSet;
            // 
            // knjigaTableAdapter
            // 
            this.knjigaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KategorijaTableAdapter = null;
            this.tableAdapterManager.KnjigaTableAdapter = this.knjigaTableAdapter;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KnjizaraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // knjigaBindingNavigator
            // 
            this.knjigaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.knjigaBindingNavigator.BindingSource = this.knjigaBindingSource;
            this.knjigaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.knjigaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.knjigaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.knjigaBindingNavigatorSaveItem});
            this.knjigaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.knjigaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.knjigaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.knjigaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.knjigaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.knjigaBindingNavigator.Name = "knjigaBindingNavigator";
            this.knjigaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.knjigaBindingNavigator.Size = new System.Drawing.Size(353, 25);
            this.knjigaBindingNavigator.TabIndex = 0;
            this.knjigaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(Resources.bindingNavigatorMoveFirstItem_Image));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(Resources.bindingNavigatorMovePreviousItem_Image));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(Resources.bindingNavigatorMoveNextItem_Image));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(Resources.bindingNavigatorMoveLastItem_Image));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(Resources.bindingNavigatorAddNewItem_Image));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(Resources.bindingNavigatorDeleteItem_Image));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // knjigaBindingNavigatorSaveItem
            // 
            this.knjigaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.knjigaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(Resources.knjigaBindingNavigatorSaveItem_Image));
            this.knjigaBindingNavigatorSaveItem.Name = "knjigaBindingNavigatorSaveItem";
            this.knjigaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.knjigaBindingNavigatorSaveItem.Text = "Save Data";
            this.knjigaBindingNavigatorSaveItem.Click += new System.EventHandler(this.knjigaBindingNavigatorSaveItem_Click);
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(59, 65);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(35, 13);
            nazivLabel.TabIndex = 1;
            nazivLabel.Text = "naziv:";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBindingSource, "naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(132, 62);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(200, 20);
            this.nazivTextBox.TabIndex = 2;
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Location = new System.Drawing.Point(59, 91);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(34, 13);
            autorLabel.TabIndex = 3;
            autorLabel.Text = "autor:";
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBindingSource, "autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(132, 88);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(200, 20);
            this.autorTextBox.TabIndex = 4;
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(59, 117);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(34, 13);
            cenaLabel.TabIndex = 5;
            cenaLabel.Text = "cena:";
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBindingSource, "cena", true));
            this.cenaTextBox.Location = new System.Drawing.Point(132, 114);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cenaTextBox.TabIndex = 6;
            // 
            // popustLabel
            // 
            popustLabel.AutoSize = true;
            popustLabel.Location = new System.Drawing.Point(59, 143);
            popustLabel.Name = "popustLabel";
            popustLabel.Size = new System.Drawing.Size(42, 13);
            popustLabel.TabIndex = 7;
            popustLabel.Text = "popust:";
            // 
            // popustTextBox
            // 
            this.popustTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBindingSource, "popust", true));
            this.popustTextBox.Location = new System.Drawing.Point(132, 140);
            this.popustTextBox.Name = "popustTextBox";
            this.popustTextBox.Size = new System.Drawing.Size(100, 20);
            this.popustTextBox.TabIndex = 8;
            // 
            // id_kategorijaLabel
            // 
            id_kategorijaLabel.AutoSize = true;
            id_kategorijaLabel.Location = new System.Drawing.Point(59, 169);
            id_kategorijaLabel.Name = "id_kategorijaLabel";
            id_kategorijaLabel.Size = new System.Drawing.Size(67, 13);
            id_kategorijaLabel.TabIndex = 9;
            id_kategorijaLabel.Text = "id kategorija:";
            // 
            // id_kategorijaComboBox
            // 
            //BINDING NA CIGANIJU
            this.id_kategorijaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBindingSource, "id_kategorija", true));
            //
            this.id_kategorijaComboBox.Location = new System.Drawing.Point(132, 166);
            this.id_kategorijaComboBox.Name = "id_kategorijaComboBox";
            this.id_kategorijaComboBox.Size = new System.Drawing.Size(100, 20);
            this.id_kategorijaComboBox.TabIndex = 10;
            foreach(strint x in main.Distinct_Kat)
            {
                id_kategorijaComboBox.Items.Add(x.s+" - "+x.i);
            }
            // 
            // Back_Admin_Passed
            // 
            this.Back_Admin_Passed.Location = new System.Drawing.Point(62, 216);
            this.Back_Admin_Passed.Name = "Back_Admin_Passed";
            this.Back_Admin_Passed.Size = new System.Drawing.Size(170, 23);
            this.Back_Admin_Passed.TabIndex = 11;
            this.Back_Admin_Passed.Text = "Povratak na Glavnu Formu";
            this.Back_Admin_Passed.UseVisualStyleBackColor = true;
            this.Back_Admin_Passed.Click += new System.EventHandler(this.Back_Button_Click);
        }

        private void Adding_Books_Add()
        {


            this.knjigaTableAdapter.Fill(this.knjizaraDataSet.Knjiga);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 275);
            this.Controls.Add(this.Back_Admin_Passed);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(popustLabel);
            this.Controls.Add(this.popustTextBox);
            this.Controls.Add(id_kategorijaLabel);
            this.Controls.Add(this.id_kategorijaComboBox);
            this.Controls.Add(this.knjigaBindingNavigator);
            this.Name = "Form1";
            this.Text = "Dodavanje Knjiga";
            ((System.ComponentModel.ISupportInitialize)(this.knjizaraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingNavigator)).EndInit();
            this.knjigaBindingNavigator.ResumeLayout(false);
            this.knjigaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        #region Racuni

        #region Declaration


        private System.Windows.Forms.DateTimePicker since_Date;
        private System.Windows.Forms.TextBox since_TB;
        private System.Windows.Forms.Button Selected_BTN;
        private System.Windows.Forms.GroupBox since_Group;
        private System.Windows.Forms.Label Time_1_LB;
        private System.Windows.Forms.Label Date_1_LB;
        private System.Windows.Forms.GroupBox until_Group;
        private System.Windows.Forms.Label Time1_LB;
        private System.Windows.Forms.Label Date2_LB;
        private System.Windows.Forms.DateTimePicker until_Date;
        private System.Windows.Forms.TextBox until_TB;
        private System.Windows.Forms.Button Back_Button_Racuni;
        private System.Windows.Forms.Label Time_FORM_LB;
        private System.Windows.Forms.Label Time_FRM_LB;
        #endregion

        public void Init_Racuni()
        {

            this.since_Date = new System.Windows.Forms.DateTimePicker();
            this.since_TB = new System.Windows.Forms.TextBox();
            this.Selected_BTN = new System.Windows.Forms.Button();
            this.since_Group = new System.Windows.Forms.GroupBox();
            this.Time_1_LB = new System.Windows.Forms.Label();
            this.Date_1_LB = new System.Windows.Forms.Label();
            this.until_Group = new System.Windows.Forms.GroupBox();
            this.Time1_LB = new System.Windows.Forms.Label();
            this.Date2_LB = new System.Windows.Forms.Label();
            this.until_Date = new System.Windows.Forms.DateTimePicker();
            this.until_TB = new System.Windows.Forms.TextBox();
            this.Back_Button_Racuni = new System.Windows.Forms.Button();
            this.Time_FRM_LB = new System.Windows.Forms.Label();
            this.Time_FORM_LB = new System.Windows.Forms.Label();
            this.since_Group.SuspendLayout();
            this.until_Group.SuspendLayout();
        }
        public void Racuni_Set()
        {
            // 
            // since_Date
            // 
            this.since_Date.Location = new System.Drawing.Point(63, 28);
            this.since_Date.Name = "since_Date";
            this.since_Date.Size = new System.Drawing.Size(200, 20);
            this.since_Date.TabIndex = 0;
            // 
            // since_TB
            // 
            this.since_TB.Location = new System.Drawing.Point(63, 60);
            this.since_TB.Name = "since_TB";
            this.since_TB.Size = new System.Drawing.Size(100, 20);
            this.since_TB.TabIndex = 6;
            // 
            // Selected_BTN
            // 
            this.Selected_BTN.Location = new System.Drawing.Point(12, 224);
            this.Selected_BTN.Name = "Selected_BTN";
            this.Selected_BTN.Size = new System.Drawing.Size(139, 39);
            this.Selected_BTN.TabIndex = 8;
            this.Selected_BTN.Text = "Prikazi Racune";
            this.Selected_BTN.UseVisualStyleBackColor = true;
            this.Selected_BTN.Click += new System.EventHandler(this.Selected_BTN_Click);
            // 
            // since_Group
            // 
            this.since_Group.Controls.Add(this.Time_FORM_LB);
            this.since_Group.Controls.Add(this.Time_1_LB);
            this.since_Group.Controls.Add(this.Date_1_LB);
            this.since_Group.Controls.Add(this.since_Date);
            this.since_Group.Controls.Add(this.since_TB);
            this.since_Group.Location = new System.Drawing.Point(12, 12);
            this.since_Group.Name = "since_Group";
            this.since_Group.Size = new System.Drawing.Size(329, 100);
            this.since_Group.TabIndex = 9;
            this.since_Group.TabStop = false;
            this.since_Group.Text = "OD";
            // 
            // Time_1_LB
            // 
            this.Time_1_LB.AutoSize = true;
            this.Time_1_LB.Location = new System.Drawing.Point(10, 63);
            this.Time_1_LB.Name = "Time_1_LB";
            this.Time_1_LB.Size = new System.Drawing.Size(52, 13);
            this.Time_1_LB.TabIndex = 8;
            this.Time_1_LB.Text = "Vremena:";
            // 
            // Date_1_LB
            // 
            this.Date_1_LB.AutoSize = true;
            this.Date_1_LB.Location = new System.Drawing.Point(9, 31);
            this.Date_1_LB.Name = "Date_1_LB";
            this.Date_1_LB.Size = new System.Drawing.Size(47, 13);
            this.Date_1_LB.TabIndex = 7;
            this.Date_1_LB.Text = "Datuma:";
            // 
            // until_Group
            // 
            this.until_Group.Controls.Add(this.Time_FRM_LB);
            this.until_Group.Controls.Add(this.Time1_LB);
            this.until_Group.Controls.Add(this.Date2_LB);
            this.until_Group.Controls.Add(this.until_Date);
            this.until_Group.Controls.Add(this.until_TB);
            this.until_Group.Location = new System.Drawing.Point(12, 118);
            this.until_Group.Name = "until_Group";
            this.until_Group.Size = new System.Drawing.Size(329, 100);
            this.until_Group.TabIndex = 10;
            this.until_Group.TabStop = false;
            this.until_Group.Text = "DO";
            // 
            // Time1_LB
            // 
            this.Time1_LB.AutoSize = true;
            this.Time1_LB.Location = new System.Drawing.Point(10, 63);
            this.Time1_LB.Name = "Time1_LB";
            this.Time1_LB.Size = new System.Drawing.Size(52, 13);
            this.Time1_LB.TabIndex = 8;
            this.Time1_LB.Text = "Vremena:";
            // 
            // Date2_LB
            // 
            this.Date2_LB.AutoSize = true;
            this.Date2_LB.Location = new System.Drawing.Point(9, 31);
            this.Date2_LB.Name = "Date2_LB";
            this.Date2_LB.Size = new System.Drawing.Size(47, 13);
            this.Date2_LB.TabIndex = 7;
            this.Date2_LB.Text = "Datuma:";
            // 
            // until_Date
            // 
            this.until_Date.Location = new System.Drawing.Point(63, 28);
            this.until_Date.Name = "until_Date";
            this.until_Date.Size = new System.Drawing.Size(200, 20);
            this.until_Date.TabIndex = 0;
            // 
            // until_TB
            // 
            this.until_TB.Location = new System.Drawing.Point(63, 60);
            this.until_TB.Name = "until_TB";
            this.until_TB.Size = new System.Drawing.Size(100, 20);
            this.until_TB.TabIndex = 6;
            // 
            // Back_Button_Racuni
            // 
            this.Back_Button_Racuni.Location = new System.Drawing.Point(186, 224);
            this.Back_Button_Racuni.Name = "Back_Button_Racuni";
            this.Back_Button_Racuni.Size = new System.Drawing.Size(139, 39);
            this.Back_Button_Racuni.TabIndex = 11;
            this.Back_Button_Racuni.Text = "Povratak na glavnu stranu";
            this.Back_Button_Racuni.UseVisualStyleBackColor = true;
            this.Back_Button_Racuni.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Time_FRM_LB
            // 
            this.Time_FRM_LB.AutoSize = true;
            this.Time_FRM_LB.Location = new System.Drawing.Point(171, 63);
            this.Time_FRM_LB.Name = "Time_FRM_LB";
            this.Time_FRM_LB.Size = new System.Drawing.Size(130, 13);
            this.Time_FRM_LB.TabIndex = 12;
            this.Time_FRM_LB.Text = "(Format mora biti HH:MM )";
            // 
            // Time_FORM_LB
            // 
            this.Time_FORM_LB.AutoSize = true;
            this.Time_FORM_LB.Location = new System.Drawing.Point(171, 63);
            this.Time_FORM_LB.Name = "Time_FORM_LB";
            this.Time_FORM_LB.Size = new System.Drawing.Size(130, 13);
            this.Time_FORM_LB.TabIndex = 13;
            this.Time_FORM_LB.Text = "(Format mora biti HH:MM )";
        }

        public void Racuni_Add()
        {
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 275);
            this.Controls.Add(this.Back_Button_Racuni);
            this.Controls.Add(this.until_Group);
            this.Controls.Add(this.since_Group);
            this.Controls.Add(this.Selected_BTN);
            this.Name = "Form3";
            this.Text = "Form3";
            this.since_Group.ResumeLayout(false);
            this.since_Group.PerformLayout();
            this.until_Group.ResumeLayout(false);
            this.until_Group.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        #region Methods
        public static class Useful
        {
            public static string First_Letter_Upper(string Start_String)
            {
                char[] firstl = Start_String.ToCharArray();
                firstl[0] = char.ToUpper(firstl[0]);
                return new string(firstl);
            }
        }
        #endregion

        #region Custom_Data_Types
        public struct floastring
        {
            public string s { get; }
            public float i { get; }
            public floastring(string string_, int int_)
            {
                s = string_;
                i = int_;
            }
        }

        public struct strint
        {
            public string s;
            public int i;
            public strint(string str, int int_)
            {
                s = str;
                i = int_;
            }
        }
        public class Data_Struct
        {
            public int id_knjige { get; }
            public string naziv_knjige { get; }
            public string autor { get; }
            public int cena { get; }
            public int popust { get; }
            public int id_kategorije { get; }
            public string naziv_kategorije { get; }
            public Data_Struct(int id_M, string name_m, string author, int price, int sale, int id_S, string name_S)
            {
                id_knjige = id_M;
                naziv_knjige = name_m;
                autor = author;
                cena = price;
                popust = sale;
                id_kategorije = id_S;
                naziv_kategorije = name_S;
            }
            public Data_Struct(Data_Struct d)
            {
                id_knjige = d.id_knjige;
                naziv_knjige = d.naziv_knjige;
                autor = d.autor;
                cena = d.cena;
                popust = d.popust;
                id_kategorije = d.id_kategorije;
                naziv_kategorije = d.naziv_kategorije;
            }

            //public get/set;


        }
        public class List_Structs
        {
            private IList<Data_Struct> ds;
            public HashSet<strint> Distinct_Kat { get; set; }
            public List_Structs()
            {
                ds = new List<Data_Struct>();
                Distinct_Kat = new HashSet<strint>();
            }
            private void Add(int id_M, string name_m, string author, int price, int sale, int id_S, string name_S)
            {
                ds.Add(new Data_Struct(id_M, name_m, author, price, sale, id_S, name_S));
            }

            public int Populate()
            {
                ds.Clear();
                KnjizaraDataSet ds_h = new KnjizaraDataSet();
                KnjigaTableAdapter ka = new KnjigaTableAdapter();
                ka.Fill_Full(ds_h.Knjiga);

                foreach (DataRow dr in ds_h.Knjiga)
                {
                    int id_n = 0, cena = 0, popust = 0, id_kat = 0;
                    string naziv_kat = "";
                    int.TryParse(dr[0].ToString(), out id_n);
                    int.TryParse(dr[3].ToString(),out cena);
                    int.TryParse(dr[4].ToString(), out popust);
                    int.TryParse(dr[5].ToString(), out id_kat);
                    if (id_n == 0 || cena == 0)
                    {
                        return 0;
                    }
                    else if (id_kat == 0 && dr[6].ToString()!="" && dr[6].ToString()!=string.Empty)
                    {
                        KnjizaraDataSet.KategorijaDataTable kat_DT = new KnjizaraDataSet.KategorijaDataTable();
                        KategorijaTableAdapter k_a = new KategorijaTableAdapter();
                        naziv_kat = dr[6].ToString();
                        k_a.FillBy(kat_DT, naziv_kat);
                        int.TryParse(kat_DT[0][0].ToString(), out id_kat);
                        if(id_kat==0)
                        {
                            k_a.InsertQuery(naziv_kat);
                            kat_DT.Clear();
                            k_a.FillBy(kat_DT, naziv_kat);
                            int.TryParse(kat_DT[0][0].ToString(), out id_kat);
                        }
                    }
                    else if (id_kat == 0 && (dr[6].ToString() == "" || dr[6].ToString() == string.Empty))
                    {
                        KnjizaraDataSet.KategorijaDataTable kat_DT = new KnjizaraDataSet.KategorijaDataTable();
                        KategorijaTableAdapter k_a = new KategorijaTableAdapter();
                        naziv_kat = "Ostalo";
                        k_a.InsertQuery(naziv_kat);
                        k_a.FillBy(kat_DT,naziv_kat);
                        int.TryParse(kat_DT[0][0].ToString(), out id_kat);
                        
                    }
                    else
                    {
                        naziv_kat = dr[6].ToString();
                    }
                    Add(id_n, dr[1].ToString(), dr[2].ToString(), cena, popust, id_kat, naziv_kat);
                    strint temp = new strint(naziv_kat, id_kat);
                    Distinct_Kat.Add(temp);
                }
                return 1;
            }

            public List<string> Genres()
            {
                List<string> result = new List<string>();
                List<string> added = new List<string>();


                result.Add("");


                foreach (Data_Struct d in ds)
                {
                    if (!added.Contains(d.naziv_kategorije))
                    {
                        string res = Useful.First_Letter_Upper(d.naziv_kategorije);
                        result.Add(res);
                        added.Add(d.naziv_kategorije);
                    }
                }

                return result;
            }
            public List<string> Genres(string Author)
            {
                List<string> result = new List<string>();
                List<string> added = new List<string>();

                result.Add("");

                foreach (Data_Struct d in ds)
                {
                    if (!added.Contains(d.naziv_kategorije) && d.autor.ToLower().Contains(Author.ToLower()))
                    {
                        result.Add(Useful.First_Letter_Upper(d.naziv_kategorije));
                        added.Add(d.naziv_kategorije);
                    }
                }


                return result;
            }

            public List<string> Authors()
            {
                List<string> result = new List<string>();
                List<string> added = new List<string>();


                result.Add("");

                foreach (Data_Struct d in ds)
                {
                    if (!added.Contains(d.autor))
                    {
                        string res = Useful.First_Letter_Upper(d.autor);
                        result.Add(res);
                        added.Add(d.autor);
                    }
                }

                return result;
            }
            public List<string> Authors(string Genre)
            {
                List<string> result = new List<string>();
                List<string> added = new List<string>();

                result.Add("");

                foreach (Data_Struct d in ds)
                {
                    if (!added.Contains(d.autor) && d.naziv_kategorije.ToLower() == Genre.ToLower())
                    {
                        result.Add(Useful.First_Letter_Upper(d.autor));
                        added.Add(d.autor);
                    }
                }


                return result;
            }

            public List<string> Books(string Author, string Genre)
            {
                List<string> result = new List<string>();
                List<string> added = new List<string>();

                result.Add("");

                foreach (Data_Struct d in ds)
                {

                    if (Genre == "" && Author == "")
                    {
                        if (!added.Contains(d.naziv_knjige))
                        {
                            result.Add(Useful.First_Letter_Upper(d.naziv_knjige));
                            added.Add(d.naziv_knjige);
                        }
                    }
                    else if (Genre == "")
                    {
                        if (!added.Contains(d.naziv_knjige) && d.autor.ToLower() == (Author.ToLower()))
                        {
                            result.Add(Useful.First_Letter_Upper(d.naziv_knjige));
                            added.Add(d.naziv_knjige);
                        }
                    }
                    else if (Author == "")
                    {
                        if (!added.Contains(d.naziv_knjige) && d.naziv_kategorije.ToLower() == (Genre.ToLower()))
                        {
                            result.Add(Useful.First_Letter_Upper(d.naziv_knjige));
                            added.Add(d.naziv_knjige);
                        }
                    }
                    else if (!added.Contains(d.naziv_knjige) && d.autor.ToLower() == (Author.ToLower()) && d.naziv_kategorije.ToLower() == (Genre.ToLower()))
                    {
                        result.Add(Useful.First_Letter_Upper(d.naziv_knjige));
                        added.Add(d.naziv_knjige);
                    }
                }
                return result;
            }

            public List<string> Book_Names_By_User(string Book_Name)
            {
                List<string> result = new List<string>();
                List<string> added = new List<string>();


                foreach (Data_Struct d in ds)
                {
                    if (!added.Contains(d.naziv_knjige) && d.naziv_knjige.ToLower().Contains(Book_Name.ToLower()))
                    {
                        string h=string.Format("Pronadjena je knjiga ,{0}, koju je napisao ,{1}, i zanra je {2}.", Useful.First_Letter_Upper(d.naziv_knjige), Useful.First_Letter_Upper(d.autor), Useful.First_Letter_Upper(d.naziv_kategorije));
                        result.Add(h);
                        added.Add(d.naziv_knjige);
                    }
                }
                return result;
            }
            public List<string> Book_Names_By_Author(string Author)
            {
                List<string> result = new List<string>();
                List<string> added = new List<string>();

                foreach (Data_Struct d in ds)
                {
                    if (!added.Contains(d.naziv_knjige) && d.autor.ToLower().Contains(Author.ToLower()))
                    {
                        string h = string.Format("Pronadjena je knjiga ,{0}, koju je napisao ,{1}, i zanra je {2}.", Useful.First_Letter_Upper(d.naziv_knjige), Useful.First_Letter_Upper(d.autor), Useful.First_Letter_Upper(d.naziv_kategorije));
                        result.Add(h);
                        added.Add(d.naziv_knjige);
                    }
                }
                return result;
            }

            public floastring To_Basket(string Name)
            {
                foreach (Data_Struct d in ds)
                {
                    if (d.naziv_knjige.ToLower() == (Name.ToLower()))
                    {
                        if (d.popust != 0)
                        {
                            floastring out_ = new floastring(string.Format("{0} njena cena je :{1}", Useful.First_Letter_Upper(d.naziv_knjige), d.cena), d.cena);
                            return out_;
                        }
                        else
                        {
                            floastring out_ = new floastring(string.Format("{0} je trenutno na popustu i njena cena je :{1}", Useful.First_Letter_Upper(d.naziv_knjige), (d.cena - ((d.cena / 100) * d.popust))), (d.cena - ((d.cena / 100) * d.popust)));
                            return out_;
                        }
                    }
                }
                return new floastring("", 0);
            }
        }

        #endregion

        #region Declarations
        List_Structs main;
        float price = 0;
        floastring fs;

        bool flag_genre = false;
        bool flag_author = false;

        bool flag_box = false;
        bool flag_list = false;

        bool admin_Change = false;
        #endregion


        public Form1()
        {

            main = new List_Structs();
            if(main.Populate()==1)
            {
                Init();
                Init_Racuni();

                Standard();
                Admin_Check_Set_Proporties();
                Racuni_Set();

                //Start at?
                Standard_Add();



                Genre_Box.Items.AddRange(main.Genres().ToArray());
                Author_Box.Items.AddRange(main.Authors().ToArray());
                Book_Boox.Items.AddRange(main.Books("", "").ToArray());

            }
            else
            {
                MessageBox.Show("Problem sa citanjem cena iz databaze\n Molimo vas da proverite bazu!");

                this.Controls.Clear();
                admin_Change = true;
                Admin_Check_Add();
            }


            //Admin_Check_Add();

            //Adding_Books();
            //Adding_Books_Add();
        }


        #region Customer_Side

        private void Genre_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!flag_genre)
            {
                string genre_ = "", author_ = "";
                switch (Genre_Box.SelectedIndex)
                {
                    case var _1 when Genre_Box.SelectedIndex <= 0:
                        switch (Author_Box.SelectedIndex)
                        {
                            case var _1_1 when Author_Box.SelectedIndex <= 0: // KADA JE GENRE 0 I AUTOR 0
                                Author_Box.Items.Clear();
                                Author_Box.Items.AddRange(main.Authors().ToArray());
                                break;
                            default://  KADA JE GENRE 0 A AUTOR JE NE0
                                object helper = Author_Box.SelectedItem;
                                Author_Box.Items.Clear();
                                Author_Box.Items.AddRange(main.Authors().ToArray());

                                flag_author = !flag_author;
                                Author_Box.SelectedItem = helper;
                                flag_author = !flag_author;


                                author_ = helper.ToString();
                                break;
                        }
                        break;
                    default:
                        genre_ = Genre_Box.SelectedItem.ToString();
                        switch (Author_Box.SelectedIndex)
                        {
                            case var _1_2 when Author_Box.SelectedIndex <= 0: // KADA JE GENRE NE0 I AUTOR 0
                                Author_Box.Items.Clear();
                                Author_Box.Items.AddRange(main.Authors(genre_).ToArray());
                                break;
                            default://  KADA JE GENRE NE0 A AUTOR JE NE0
                                object helper = Author_Box.SelectedItem;
                                Author_Box.Items.Clear();
                                Author_Box.Items.AddRange(main.Authors(genre_).ToArray());

                                flag_author = !flag_author;
                                Author_Box.SelectedItem = helper;
                                flag_author = !flag_author;


                                author_ = helper.ToString();
                                break;
                        }
                        break;
                }

                Book_Boox.Items.Clear();
                Book_Boox.Items.AddRange(main.Books(author_, genre_).ToArray());
            }
        }

        private void Author_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!flag_author)
            {
                string genre_ = "", author_ = "";
                switch (Author_Box.SelectedIndex)
                {
                    case var _ when Author_Box.SelectedIndex <= 0:
                        Author_Box.Items.Clear();
                        switch (Genre_Box.SelectedIndex)
                        {
                            case var _1 when Genre_Box.SelectedIndex <= 0:// KADA JE AUTOR 0 I GENRE JE 0
                                Genre_Box.Items.Clear();
                                Genre_Box.Items.AddRange(main.Genres().ToArray());
                                Author_Box.Items.AddRange(main.Authors().ToArray());
                                break;
                            default://KADA JE AUTHOR "" A GENRE NIJE ""
                                object helper = Genre_Box.SelectedItem;
                                Genre_Box.Items.Clear();
                                Genre_Box.Items.AddRange(main.Genres().ToArray());


                                flag_genre = !flag_genre;
                                Genre_Box.SelectedItem = helper;
                                flag_genre = !flag_genre;

                                genre_ = helper.ToString();

                                Author_Box.Items.AddRange(main.Authors(genre_).ToArray());
                                break;

                        }
                        break;
                    default:
                        author_ = Author_Box.SelectedItem.ToString();
                        switch (Genre_Box.SelectedIndex)
                        {
                            case var _1 when Genre_Box.SelectedIndex <= 0://KADA JE AUTOR NESTO A GENRE JE 0
                                Genre_Box.Items.Clear();
                                Genre_Box.Items.AddRange(main.Genres(author_).ToArray());
                                break;
                            default://KADA JE AUTOR NESTO I ZANR JE NESTO

                                object helper = Genre_Box.SelectedItem;
                                Genre_Box.Items.Clear();
                                Genre_Box.Items.AddRange(main.Genres(author_).ToArray());


                                flag_genre = !flag_genre;
                                Genre_Box.SelectedItem = helper;
                                flag_genre = !flag_genre;

                                genre_ = helper.ToString();
                                break;

                        }
                        break;
                }
                Book_Boox.Items.Clear();
                Book_Boox.Items.AddRange(main.Books(author_, genre_).ToArray());

            }
        }

        private void Book_Boox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!flag_box)
            {
                flag_list = !flag_list;
                Search_Results.SelectedIndex = -1;
                flag_list = !flag_list;
            }
        }
        private void Search_Results_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!flag_list)
            {
                flag_box = !flag_box;
                Book_Boox.SelectedIndex = 0;
                flag_box = !flag_box;
            }
        }



        private void by_Book_Name_Click(object sender, EventArgs e)
        {
            string[] temp = main.Book_Names_By_User(Search_By_x_TB.Text).ToArray();
            Search_Results.Items.Clear();
            if (temp.Count()>0)
            {
                Search_Results.Items.AddRange(temp);
            }
        }

        private void by_Author_Name_Click(object sender, EventArgs e)
        {
            string[] temp = main.Book_Names_By_Author(Search_By_x_TB.Text).ToArray();
            Search_Results.Items.Clear();
            if (temp.Count() > 0)
            {
                Search_Results.Items.AddRange(temp);
            }
        }
        private void To_Basket_Btn_Click(object sender, EventArgs e)
        {

            int volume = 0;
            int.TryParse(Volume_TB.Text, out volume);

            if (Book_Boox.SelectedIndex > 0)
            {
                if (volume > 0)
                {
                    fs = main.To_Basket(Book_Boox.SelectedItem.ToString());
                    Basket.Items.Add(string.Format("{0} i stavili ste ,{1} njih u korpu", fs.s, volume));
                    price += fs.i * volume;
                    racun_Label.Text = string.Format("Ukupan iznos za placanje: {0}", price.ToString());
                }
                else
                {
                    MessageBox.Show("Morate postaviti koliko komada zelite da kupite!");
                }
                
            }
            else if(Search_Results.SelectedIndex>=0)
            {

                fs = main.To_Basket(Search_Results.SelectedItem.ToString().Split(',')[1]);
                Basket.Items.Add(string.Format("{0} i stavili ste ,{1} njih u korpu", fs.s, volume));
                price += fs.i * volume;
                racun_Label.Text = string.Format("Ukupan iznos za placanje: {0}", price.ToString());
            }
            else
            {
                MessageBox.Show("Morate selektovati knjigu koju zelite da kupite jednom od dve ponudjene metode!");
            }
        }

        private void Del_Selected_Click(object sender, EventArgs e)
        {

            int volume = 0, cena = 0;
            if (Basket.SelectedIndex >= 0)
            {
                string[] help_text = Basket.SelectedItem.ToString().Split(':');
                string volume_text = help_text[help_text.Length-1].Split(',')[1].Split(' ')[0];
                string cena_text = help_text[help_text.Length - 1].Split(' ')[0];
                int.TryParse(volume_text, out volume);
                int.TryParse(cena_text, out cena);
                price -= cena * volume;
                Basket.Items.RemoveAt(Basket.SelectedIndex);
                racun_Label.Text = string.Format("Ukupan iznos za placanje: {0}",price.ToString());
            }
            else
            {
                MessageBox.Show("Da bi ste obrisali nesto iz korpe morate prvo kliknuti na to!");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Basket.Items.Clear();
            racun_Label.Text = "Ukupan iznos za placanje:";
        }

        private void Pay_Btn_Click(object sender, EventArgs e)
        {

            RacunTableAdapter ra = new RacunTableAdapter();
            string time = DateTime.Now.ToString().Split(' ')[1].Split(':')[0] + ":" + DateTime.Now.ToString().Split(' ')[1].Split(':')[1];

            if (price > 0)
            {
                ra.Insert(price, DateTime.Parse(DateTime.Now.ToString()), time);
                MessageBox.Show("Uspesno ste uneli racun i bazu !");

                Genre_Box.Items.Clear();
                Author_Box.Items.Clear();
                Book_Boox.Items.Clear();
                Genre_Box.Items.AddRange(main.Genres().ToArray());
                Author_Box.Items.AddRange(main.Authors().ToArray());
                Book_Boox.Items.AddRange(main.Books("", "").ToArray());

            }
            else
            {
                MessageBox.Show("Vas racun je prazan");
            }
        }


        private void Add_Book_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            admin_Change = true;
            Admin_Check_Add();
        }

        private void Racuni_Check_Click(object sender, EventArgs e)
        {

            this.Controls.Clear();
            admin_Change = false;
            Admin_Check_Add();
        }

        #endregion

        #region Admin Check

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Standard_Add();

            Genre_Box.Items.Clear();
            Author_Box.Items.Clear();
            Book_Boox.Items.Clear();
            Genre_Box.Items.AddRange(main.Genres().ToArray());
            Author_Box.Items.AddRange(main.Authors().ToArray());
            Book_Boox.Items.AddRange(main.Books("", "").ToArray());
        }

        private void pass_check_Click(object sender, EventArgs e)
        {
            if (admin_Change)
            {
                if (pass_Box.Text.ToLower().Contains("29"))
                {
                    pass_Box.Text = "";
                    this.Controls.Clear();
                    Init_Add_Book_Page();
                    Adding_Books();
                    Adding_Books_Add();

                }
                else
                {
                    MessageBox.Show("Pogresna sifra!");
                }
            }
            else
            {
                if (pass_Box.Text.ToLower().Contains("29"))
                {
                    pass_Box.Text = "";
                    this.Controls.Clear();
                    Racuni_Add();
                }
                else
                {
                    MessageBox.Show("Pogresna sifra!");
                }
            }
        }
        #endregion


        #region Adding Books


        private void knjigaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            KnjizaraDataSet.KategorijaDataTable k_DT= new KnjizaraDataSet.KategorijaDataTable();
            KategorijaTableAdapter k_A = new KategorijaTableAdapter();

            k_A.ClearBeforeFill = true;

            string[] id_kat = id_kategorijaComboBox.Text.Split(' ');
            int id_kat_num = 0;
            int.TryParse(id_kat[0], out id_kat_num);
            if(id_kat.Length>1)
            {
                int.TryParse(id_kat[id_kat.Length-1], out id_kat_num);
            }
            else
            {
                foreach(string d in main.Genres())
                {
                    if(d.ToLower().Contains(id_kat[0].ToLower()))
                    {
                        k_A.FillBy(k_DT, d);
                        foreach(DataRow d_row_temp in k_DT)
                        {
                            id_kat_num = int.Parse(d_row_temp[0].ToString());
                            break;
                        }           
                    }
                }                
            }
            if(id_kat_num==0)
            {
                k_A.Insert(id_kat[0]);
            }

            //SETTING BINDED TO ID_KAT_NUM
            id_kategorijaComboBox.Text = id_kat_num.ToString();

            this.Validate();
            this.knjigaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.knjizaraDataSet);
            main.Populate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'knjizaraDataSet.Knjiga' table. You can move, or remove it, as needed.

        }



        #endregion

        #region Racuni since-until
        struct Racun_Row
        {
            public int id { get; }
            public int cena { get; }
            public DateTime datum { get; }
            public TimeSpan vreme { get; }

            public DateTime datum_i_vreme { get; }
            public Racun_Row(DataRow d)
            {
                id = int.Parse(d[0].ToString());
                cena = int.Parse(d[1].ToString());
                datum = DateTime.Parse(d[2].ToString().Split(' ')[0]);
                vreme = TimeSpan.Parse(d[3].ToString());
                datum_i_vreme = datum + vreme;
            }
        }
        private void Selected_BTN_Click(object sender, EventArgs e)
        {
            RacunTableAdapter ra = new RacunTableAdapter();
            KnjizaraDataSet.RacunDataTable R_dt = new KnjizaraDataSet.RacunDataTable();

            DateTime since_D = DateTime.Parse(since_Date.Value.ToString().Split(' ')[0]);
            DateTime until_D = DateTime.Parse(until_Date.Value.ToString().Split(' ')[0]);

            if(since_TB.Text=="" || since_TB.Text==string.Empty)
            {
                since_TB.Text = "00:00";
            }
            if(until_TB.Text==""|| until_TB.Text==string.Empty)
            {
                until_TB.Text = "00:00";
            }

            TimeSpan since_T = TimeSpan.Parse(since_TB.Text);
            TimeSpan until_T = TimeSpan.Parse(until_TB.Text);

            DateTime since_DT = since_D + since_T;
            DateTime until_DT = until_D + until_T;
            ra.Fill(R_dt);
            string output = "";
            foreach(DataRow dr in R_dt)
            {
                //ID_racun, cena, datum, vreme
                Racun_Row rr = new Racun_Row(dr);
                if(rr.datum_i_vreme.CompareTo(since_DT)>0 && rr.datum_i_vreme.CompareTo(until_DT)<0)
                {

                    output += string.Format("Racun sa ID-em : {0} iznosio je : {1} i izvrsen je {2} tog u {3} casova\n",rr.id,rr.cena,rr.datum.ToString().Split(' ')[0], (rr.vreme.ToString().Split(':')[0]+":"+ rr.vreme.ToString().Split(':')[1]));
                }
            }

            MessageBox.Show(output);
        }
        #endregion

    }

}