
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
	public class holyhallsAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {12294, -3, -1, 0}, {12311, -2, -4, 0}, {12294, -2, -1, 0}// 1	5	6	
			, {12294, -2, 2, 0}, {12294, -2, 5, 0}, {12294, 0, 4, 0}// 7	9	11	
			, {12294, -1, 5, 0}, {12294, 0, -1, 0}, {12310, 6, 4, 0}// 13	14	15	
			, {12294, 1, -1, 0}, {12294, -1, 0, 0}, {12294, -4, 0, 0}// 16	18	19	
			, {12294, 2, -1, 0}, {12310, -5, 5, 0}, {2944, -1, -2, 0}// 20	21	23	
			, {12294, -1, -1, 0}, {12294, -3, 1, 0}, {12294, -4, 2, 0}// 25	26	27	
			, {12294, -1, 1, 0}, {12310, 6, 0, 0}, {12310, -5, -1, 0}// 29	30	31	
			, {12310, -5, -2, 0}, {12294, 1, 0, 0}, {12311, 4, -4, 0}// 32	34	35	
			, {12294, 0, 2, 0}, {12294, 0, -2, 0}, {12310, 6, 1, 0}// 36	37	39	
			, {12294, 1, -3, 0}, {12311, -1, -4, 0}, {12311, 5, -4, 0}// 40	41	42	
			, {12294, 6, 5, 0}, {12294, 6, 4, 0}, {2943, -2, -2, 0}// 43	44	45	
			, {12294, 6, 3, 0}, {12294, 6, 2, 0}, {12294, 6, 1, 0}// 46	47	48	
			, {12294, 6, 0, 0}, {12294, 6, -1, 0}, {12294, 6, -2, 0}// 49	50	51	
			, {12294, 6, -3, 0}, {12294, 5, 5, 0}, {12294, 5, 4, 0}// 52	53	54	
			, {12294, -4, 3, 0}, {12294, -1, -2, 0}, {12294, 0, 1, 0}// 55	57	58	
			, {12294, 5, 3, 0}, {12294, 5, 2, 0}, {12311, 6, -4, 0}// 59	60	61	
			, {12294, -2, 0, 0}, {12294, -4, 4, 0}, {12294, 5, 1, 0}// 62	63	65	
			, {12311, -3, -4, 0}, {12311, 0, -4, 0}, {2944, 0, -2, 0}// 66	67	68	
			, {12294, 5, 0, 0}, {12294, 5, -1, 0}, {12294, 5, -2, 0}// 69	70	71	
			, {12294, 5, -3, 0}, {12294, 1, 5, 0}, {12310, 6, -1, 0}// 72	73	74	
			, {12294, 4, 5, 0}, {12294, -1, 2, 0}, {12294, -4, -1, 0}// 75	76	77	
			, {12294, 1, -2, 0}, {12294, 4, 4, 0}, {12294, 4, 3, 0}// 78	79	80	
			, {12294, 4, 2, 0}, {12294, 4, 1, 0}, {12294, -3, -3, 0}// 81	82	83	
			, {12294, 4, 0, 0}, {12294, 4, -1, 0}, {12294, -3, 5, 0}// 84	86	87	
			, {12294, 4, -2, 0}, {12294, 4, -3, 0}, {12294, 3, 5, 0}// 88	89	90	
			, {12294, 3, 4, 0}, {12294, 1, 4, 0}, {12294, -4, 5, 0}// 91	92	93	
			, {12294, 3, 3, 0}, {12294, -4, 1, 0}, {12294, 3, 2, 0}// 94	95	96	
			, {12294, 3, 1, 0}, {12294, 1, 2, 0}, {12294, -4, -2, 0}// 97	98	99	
			, {12294, 3, 0, 0}, {12294, 0, 0, 0}, {12294, 0, 5, 0}// 100	101	102	
			, {12294, 3, -1, 0}, {2942, 1, -2, 0}, {12310, 6, -2, 0}// 103	104	105	
			, {12294, 3, -2, 0}, {12311, 3, -4, 0}, {12294, -3, 0, 0}// 106	107	108	
			, {12294, 3, -3, 0}, {12294, 2, 5, 0}, {12294, 2, 4, 0}// 109	110	111	
			, {12310, 6, 2, 0}, {12308, 6, 5, 0}, {12294, 2, 3, 0}// 112	113	114	
			, {12294, -2, -2, 0}, {12294, 2, 2, 0}, {12294, 2, 1, 0}// 115	116	117	
			, {12294, 2, 0, 0}, {12294, 1, 3, 0}, {12310, 6, -3, 0}// 118	119	120	
			, {12294, -2, 1, 0}, {12294, -1, 3, 0}, {12311, 1, -4, 0}// 123	124	125	
			, {12294, 0, 3, 0}, {12294, 2, -3, 0}, {12309, -4, -3, 0}// 126	128	129	
			, {12311, 2, -4, 0}, {12294, -2, 3, 0}, {12294, -3, 4, 0}// 130	131	132	
			, {12294, -2, 4, 0}, {12310, -5, 0, 0}, {12294, 2, -2, 0}// 133	135	136	
			, {12294, -3, 2, 0}, {12294, -1, -1, 0}, {12310, -5, 3, 0}// 137	138	139	
			, {12294, -3, -2, 0}, {12294, -2, -3, 0}, {12294, -1, 4, 0}// 140	141	142	
			, {12294, -3, 3, 0}, {12310, -5, 1, 0}, {12294, -4, -3, 0}// 145	146	148	
			, {12294, -1, -3, 0}, {12310, 6, 3, 0}, {12310, -5, 4, 0}// 149	151	152	
			, {12294, 0, -3, 0}, {12310, -5, 2, 0}, {12311, -4, 5, 0}// 153	154	155	
			, {12294, 1, 1, 0}// 156	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new holyhallsAddonDeed();
			}
		}

		[ Constructable ]
		public holyhallsAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2921, -3, 3, 0, 33, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2920, 3, 3, 0, 33, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2922, 2, 3, 0, 33, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2922, 2, 4, 0, 33, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2920, 3, 4, 0, 33, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2920, 3, 2, 0, 33, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2922, -2, 3, 0, 33, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 2921, -3, 1, 0, 33, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2922, 2, 2, 0, 33, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 2922, -2, 2, 0, 33, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 2922, -2, 4, 0, 33, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 2920, -1, 3, 0, 33, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 2921, -3, 4, 0, 33, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 2922, -2, 1, 0, 33, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 2921, 1, 4, 0, 33, -1, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 2920, -1, 4, 0, 33, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 2922, 3, 1, 0, 33, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 2920, -1, 2, 0, 33, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 2920, -1, 1, 0, 33, -1, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 7714, 1, -1, 14, 1, -1, "Bible", 1);// 143
			AddComplexComponent( (BaseAddon) this, 2921, -3, 2, 0, 33, -1, "", 1);// 144
			AddComplexComponent( (BaseAddon) this, 2921, 1, 1, 0, 33, -1, "", 1);// 147
			AddComplexComponent( (BaseAddon) this, 2921, 1, 3, 0, 33, -1, "", 1);// 150
			AddComplexComponent( (BaseAddon) this, 2922, 2, 1, 0, 33, -1, "", 1);// 157
			AddComplexComponent( (BaseAddon) this, 2921, 1, 2, 0, 33, -1, "", 1);// 158

		}

		public holyhallsAddon( Serial serial ) : base( serial )
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

	public class holyhallsAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new holyhallsAddon();
			}
		}

		[Constructable]
		public holyhallsAddonDeed()
		{
			Name = "holyhalls";
		}

		public holyhallsAddonDeed( Serial serial ) : base( serial )
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