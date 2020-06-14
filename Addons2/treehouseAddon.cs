
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
	public class treehouseAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1981, 2, -3, 30}, {11174, 3, -3, 52}, {1981, 2, -2, 30}// 1	2	3	
			, {1981, 3, -1, 30}, {9, -3, 2, 32}, {1981, -2, -3, 30}// 4	5	6	
			, {2204, 1, 3, 24}, {1981, -2, 1, 30}, {1981, 2, 2, 30}// 7	8	9	
			, {1981, -3, 2, 30}, {11158, -2, -2, 52}, {1981, 3, -3, 30}// 10	11	12	
			, {1981, -1, 0, 30}, {1981, -1, 1, 30}, {1981, -3, -2, 30}// 13	14	15	
			, {1981, -1, -4, 30}, {1981, 1, 1, 30}, {1981, 3, -2, 30}// 16	17	18	
			, {9, 3, 2, 32}, {1981, 2, 0, 30}, {1981, 1, -2, 30}// 19	21	22	
			, {1981, 2, -1, 30}, {1981, 1, 2, 30}, {9, 3, -4, 32}// 23	24	25	
			, {11158, -1, 0, 55}, {11171, 4, -3, 52}, {9, -3, -4, 32}// 26	27	28	
			, {11169, -1, -2, 55}, {11173, 2, 2, 55}, {1981, -2, -4, 30}// 29	30	31	
			, {1981, 1, -4, 30}, {1981, -1, 2, 30}, {1981, -3, -4, 30}// 32	33	34	
			, {1981, -3, -3, 30}, {1981, -2, -2, 30}, {11173, 1, 2, 55}// 35	36	38	
			, {1981, 0, -2, 30}, {11158, -2, 0, 52}, {4587, -1, -3, 33}// 39	40	41	
			, {1981, 0, -4, 30}, {11174, 1, -3, 52}, {1981, -3, 1, 30}// 42	43	44	
			, {2205, 1, 5, 1}, {1981, -1, -1, 30}, {1981, -1, -2, 30}// 45	46	47	
			, {1981, 0, -1, 30}, {1981, -2, 2, 30}, {2205, 1, 4, 12}// 48	49	50	
			, {11170, -2, 3, 52}, {1981, 1, -3, 30}, {1981, 0, -3, 30}// 51	52	53	
			, {1981, 1, 0, 30}, {1981, 2, 1, 30}, {1981, 3, 0, 30}// 54	55	56	
			, {1981, 3, 1, 30}, {1981, 0, 1, 30}, {1981, 0, 0, 30}// 57	58	59	
			, {2869, -1, 0, 32}, {1981, -2, -1, 30}, {1981, 0, 2, 30}// 61	62	63	
			, {1981, -1, -3, 30}, {1981, 3, 2, 30}, {1981, -3, 0, 30}// 64	65	66	
			, {1981, 1, -1, 30}, {1981, -3, -1, 30}, {1981, -2, 0, 30}// 67	68	69	
			, {11157, 2, 0, 58}, {11157, 3, 1, 55}, {11174, 0, -2, 55}// 70	71	73	
			, {1981, 2, -4, 30}, {1981, 3, -4, 30}, {11171, 3, -2, 55}// 74	75	76	
			, {11157, 4, 0, 52}, {4604, -2, 1, 32}, {11173, 3, 3, 52}// 77	78	79	
			, {11169, 0, -1, 58}, {11157, 4, 1, 52}, {11173, 1, 1, 58}// 80	81	82	
			, {4584, -1, -3, 32}, {11158, -1, -1, 55}, {11158, -2, 2, 52}// 83	84	85	
			, {11168, 2, 1, 58}, {11174, 1, -1, 58}, {11173, 1, 3, 52}// 86	87	88	
			, {11174, 2, -2, 55}, {4585, 0, -3, 32}, {11157, 3, -1, 55}// 89	90	91	
			, {11168, 4, 3, 52}, {11173, 0, 2, 55}, {11158, -2, -1, 52}// 92	93	94	
			, {11170, -1, 2, 55}, {11168, 3, 2, 55}, {12072, 1, 0, 61}// 95	96	97	
			, {11174, 0, -3, 52}, {11158, -2, 1, 52}, {11158, -1, 1, 55}// 98	99	100	
			, {11157, 3, 0, 55}, {11170, 0, 1, 58}, {11174, -1, -3, 52}// 101	102	103	
			, {11169, -2, -3, 52}, {11157, 4, -2, 52}, {11173, 0, 3, 52}// 104	105	106	
			, {11173, 2, 3, 52}, {11157, 4, -1, 52}, {11157, 4, 2, 52}// 107	108	109	
			, {11158, 0, 0, 58}, {11171, 2, -1, 58}, {11174, 2, -3, 52}// 110	111	112	
			, {11174, 1, -2, 55}, {11173, -1, 3, 52}, {4604, -2, -1, 32}// 113	114	115	
			, {4010, -1, 0, 38}// 116	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new treehouseAddonDeed();
			}
		}

		[ Constructable ]
		public treehouseAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3280, -3, -4, 3, 1706, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 3280, -4, 1, 1, 1706, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 3280, 3, -4, 1, 1706, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 3280, 3, 1, 0, 1706, -1, "", 1);// 72

		}

		public treehouseAddon( Serial serial ) : base( serial )
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

	public class treehouseAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new treehouseAddon();
			}
		}

		[Constructable]
		public treehouseAddonDeed()
		{
			Name = "treehouse";
		}

		public treehouseAddonDeed( Serial serial ) : base( serial )
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