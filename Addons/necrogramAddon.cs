
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class necrogramAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {7434, 0, -1, 0}, {7424, 3, -1, 0}, {7423, 3, -2, 0}// 1	2	6	
			, {6935, 1, -1, 1}, {7415, -2, 1, 0}, {6881, 1, 0, 1}// 7	8	9	
			, {7405, 3, 1, 8}, {6882, -1, 0, 1}, {7421, 1, -2, 0}// 10	13	14	
			, {7419, -1, -2, 0}, {7426, 3, 1, 0}, {7435, 1, -1, 0}// 16	19	20	
			, {7440, 0, 1, 0}, {7425, 3, 0, 0}, {7417, -2, -1, 0}// 21	22	23	
			, {6939, 0, -1, 1}, {7422, 2, -2, 0}, {7438, 2, 1, 0}// 24	25	27	
			, {7418, -1, -1, 0}, {6938, 0, 1, 1}, {7441, 0, 0, 0}// 29	31	34	
			, {7416, -2, 0, 0}, {7432, -1, 1, 0}, {7433, -1, 0, 0}// 35	36	37	
			, {7439, 1, 1, 0}, {7442, 1, 0, 0}, {7420, 0, -2, 0}// 38	39	40	
			, {7436, 2, -1, 0}, {7437, 2, 0, 0}, {7393, 2, -1, 4}// 41	42	44	
			, {3790, -1, -1, 0}, {7412, -1, 3, 0}, {7430, 0, 2, 0}// 45	46	47	
			, {7427, 3, 2, 0}, {7407, -1, 2, 4}, {7413, -2, 3, 0}// 48	49	50	
			, {7431, -1, 2, 0}, {7414, -2, 2, 0}, {7428, 2, 2, 0}// 51	52	54	
			, {7409, 2, 3, 0}, {7411, 0, 3, 0}, {7410, 1, 3, 0}// 55	56	57	
			, {7429, 1, 2, 0}// 58	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new necrogramAddonDeed();
			}
		}

		[ Constructable ]
		public necrogramAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4628, -1, 1, 1, 1109, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 4630, 0, 0, 1, 1109, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 4624, 1, -1, 1, 1109, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 6587, 2, -3, 0, 0, 10, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 4, 0, -3, 0, 1102, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 4627, 0, 1, 1, 1109, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 4622, -1, -1, 1, 1109, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 4629, -1, 0, 1, 1109, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 4623, 0, -1, 1, 1109, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 6587, -2, -3, 0, 0, 10, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 6571, 0, 0, 5, 0, 29, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 4626, 1, 1, 1, 1109, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 5, 1, -3, 0, 1102, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 4625, 1, 0, 1, 1109, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 7408, 1, 3, 7, 2450, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 11596, 0, 4, 0, 1104, -1, "bookstand", 1);// 59

		}

		public necrogramAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class necrogramAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new necrogramAddon();
			}
		}

		[Constructable]
		public necrogramAddonDeed()
		{
			Name = "necrogram";
		}

		public necrogramAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}