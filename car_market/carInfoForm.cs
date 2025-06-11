using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_market
{
    public partial class carInfoForm : Form
    {
        public string name_branddb, name_modeldb, widthdb, heightdb, lengthdb, engine_capacitydb, body_typedb, categorydb, pricedb, name_colordb;

        private readonly carsForm _carInfo;
        private void carInfoForm_Shown(object sender, EventArgs e)
        {
            name_brand.Text = name_branddb ?? "???";
            name_model.Text = name_modeldb ?? "???";
            width.Text = widthdb ?? "???";
            height.Text = heightdb ?? "???";
            length.Text = lengthdb ?? "???";
            engine_capacity.Text = engine_capacitydb ?? "???";
            body_type.Text = body_typedb ?? "???";
            category.Text = categorydb ?? "???";
            price.Text = pricedb ?? "???";
            name_color.Text = name_colordb ?? "???";
        }

        public carInfoForm(carsForm carsForm)
        {
            InitializeComponent();
            _carInfo = carsForm;
        }
        public void Display()
        {
            name_brand.Text = name_branddb ?? "";
            name_model.Text = name_modeldb ?? "";
            width.Text = widthdb ?? "";
            height.Text = heightdb ?? "";
            length.Text = lengthdb ?? "";
            engine_capacity.Text = engine_capacitydb ?? "";
            body_type.Text = body_typedb ?? "";
            category.Text = categorydb ?? "";
            price.Text = pricedb ?? "";
            name_color.Text = name_colordb ?? "";
            //dbcar_market.DisplayAndSearch("select cc.idcar, cc.name_brand, cc.name_model, cc.price, cc.availability from (select c.idcar, mm.name_brand, mm.name_model, mm.width, mm.height, mm.length, mm.engine_capacity, mm.body_type, mm.category, c.price, c.availability, c.color_idcolor from (select m.idmodel, b.name_brand, m.name_model, width, height, length, engine_capacity, body_type, category from brand b inner join model m on b.idbrand = m.brand_idbrand) mm inner join car c on mm.idmodel = c.model_idmodel) cc inner join color co on co.idcolor = cc.color_idcolor where cc.idcar = @id;");
        }
    }
}
