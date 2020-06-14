
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
	public class HeartWellAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {9535, 0, -2, 0}, {9537, 1, -3, 0}, {9551, 2, -3, 0}// 1	2	3	
			, {16131, 3, -2, 0}, {16116, -1, -1, 1}, {16114, -2, 0, 1}// 4	5	6	
			, {9546, -2, 1, 1}, {9548, -1, 2, 1}, {9543, 3, -1, 0}// 7	8	9	
			, {9543, 3, 0, 0}, {9543, 3, 1, 0}, {9550, 0, 2, 1}// 10	11	12	
			, {9550, 1, 2, 1}, {9550, 2, 2, 1}, {491, 3, 2, 4}// 13	14	15	
			, {491, 3, 2, 7}, {491, 3, 2, 10}, {491, 3, 2, 13}// 16	17	18	
			, {491, 3, 2, 16}, {491, 3, 2, 19}, {491, 3, 2, 22}// 19	20	21	
			, {491, 3, 2, 23}, {491, 0, -1, 23}, {491, 0, -1, 24}// 22	23	24	
			, {3220, -2, 2, 1}, {3220, 4, -1, 1}, {3209, 4, 0, 1}// 25	26	27	
			, {3209, -3, 1, 1}, {3234, 4, 2, 1}, {3231, 2, 2, 1}// 28	29	30	
			, {6811, 3, 3, 4}, {6811, 4, 2, 7}, {3210, -1, 3, 1}// 33	34	35	
			, {3210, 2, 3, 1}, {6816, -1, 2, 3}, {6814, 3, -1, 1}// 36	37	38	
			, {3233, 3, -3, 1}, {3205, 4, 0, 5}, {3265, 0, 3, 4}// 39	40	41	
			, {3263, -2, 2, 5}, {3263, 4, -1, 3}, {9037, -2, 3, 3}// 42	43	44	
			, {9036, 4, 1, 11}, {3211, 1, 3, 1}, {3212, 4, -2, 1}// 45	46	47	
			, {6814, 3, 0, 1}, {6814, 3, -2, 1}, {6816, 1, 2, 2}// 48	49	50	
			, {6816, 0, 2, 2}, {3314, 4, 2, 3}, {3310, 1, 3, 1}// 51	52	53	
			, {6814, 3, 1, 1}, {6816, 2, 2, 2}, {6051, 0, -2, 16}// 54	55	56	
			, {6047, -1, -1, 16}, {6054, 1, -2, 26}, {6060, 0, -1, 16}// 57	58	59	
			, {6063, -1, 0, 27}, {6051, -2, 0, 16}, {6047, 1, -3, 15}// 60	61	62	
			, {6049, -1, 1, 16}, {6049, 0, 1, 16}, {6049, 1, 1, 16}// 63	64	65	
			, {6045, 2, 0, 16}, {6045, 2, -1, 16}, {6045, 2, -2, 16}// 66	67	68	
			, {6044, 0, 0, 16}, {6044, -1, 0, 16}, {6044, 1, 0, 16}// 69	70	71	
			, {6044, 1, -1, 16}, {6044, 1, -2, 16}, {6039, 2, 1, 16}// 72	73	74	
			, {6053, 2, -3, 15}, {6056, -2, 1, 16}, {3223, -1, 3, 5}// 75	76	77	
			, {3223, 4, 3, 5}, {3245, 3, 3, 4}, {6815, 4, 3, 8}// 78	79	80	
			, {3339, 1, 0, 16}, {3336, 1, -2, 16}, {3335, 2, -2, 16}// 81	82	83	
			, {3521, 0, -1, 16}, {3521, -1, 0, 19}, {3521, 0, 1, 19}// 84	85	86	
			, {3265, 4, 1, 4}, {3265, 3, -3, 1}, {3203, -3, 1, 1}// 87	88	91	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new HeartWellAddonDeed();
			}
		}

		[ Constructable ]
		public HeartWellAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3377, -1, -2, 7, 1241, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 3377, 4, -3, 6, 296, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 3377, -3, 1, 1, 56, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 3377, -1, -3, 4, 1546, -1, "", 1);// 90

		}

		public HeartWellAddon( Serial serial ) : base( serial )
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

	public class HeartWellAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new HeartWellAddon();
			}
		}

		[Constructable]
		public HeartWellAddonDeed()
		{
			Name = "HeartWell";
		}

		public HeartWellAddonDeed( Serial serial ) : base( serial )
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