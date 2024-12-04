using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaiWDFA0303
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFoodItem.Text))
            {
                lstFoodItems.Items.Add(txtFoodItem.Text);
                txtFoodItem.Clear();
                txtFoodItem.Focus();
            }
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(lstFoodItems, lstSelectedItems);
        }

        private void btnMoveAllRight_Click(object sender, EventArgs e)
        {
            MoveAllItems(lstFoodItems, lstSelectedItems);
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(lstSelectedItems, lstFoodItems);
        }

        private void btnMoveAllLeft_Click(object sender, EventArgs e)
        {
            MoveAllItems(lstSelectedItems, lstFoodItems);
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            MoveItem(lstSelectedItems, -1);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            MoveItem(lstSelectedItems, 1);
        }

        private void MoveSelectedItems(ListBox from, ListBox to)
        {
            List<object> selectedItems = new List<object>(from.SelectedItems.Count);
            foreach (var item in from.SelectedItems)
            {
                selectedItems.Add(item);
            }

            foreach (var item in selectedItems)
            {
                to.Items.Add(item);
                from.Items.Remove(item);
            }
        }

        private void MoveAllItems(ListBox from, ListBox to)
        {
            List<object> allItems = new List<object>(from.Items.Count);
            foreach (var item in from.Items)
            {
                allItems.Add(item);
            }

            foreach (var item in allItems)
            {
                to.Items.Add(item);
                from.Items.Remove(item);
            }
        }

        private void MoveItem(ListBox listBox, int direction)
        {
            if (listBox.SelectedItem == null || listBox.SelectedIndex < 0)
                return;

            int newIndex = listBox.SelectedIndex + direction;

            if (newIndex < 0 || newIndex >= listBox.Items.Count)
                return;

            object selected = listBox.SelectedItem;

            listBox.Items.Remove(selected);
            listBox.Items.Insert(newIndex, selected);
            listBox.SetSelected(newIndex, true);
        }
    }
}