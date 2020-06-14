
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
	public class outhouseAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {8, -3, -1, 0}, {7, -2, -2, 0}, {7, -1, -2, 0}// 1	2	3	
			, {7, 0, -2, 0}, {7, -1, 1, 0}, {8, 0, -1, 0}// 4	5	6	
			, {7, 2, -2, 0}, {8, 2, -1, 0}, {7, 2, 1, 0}// 7	8	9	
			, {2878, 1, -1, 0}, {8, 2, 1, 0}, {8, -3, 1, 0}// 10	11	12	
			, {4550, -2, -1, 4}, {7608, -2, -1, 5}, {4174, -2, -1, 4}// 13	14	15	
			, {4239, -1, -1, 11}, {933, -1, -1, 4}, {1190, -2, -1, 0}// 16	20	21	
			, {1190, -2, 0, 0}, {1190, -2, 1, 0}, {1190, -1, -1, 0}// 22	23	24	
			, {1190, -1, 0, 0}, {1190, -1, 1, 0}, {1190, 0, -1, 0}// 25	26	27	
			, {1190, 0, 0, 0}, {1190, 0, 1, 0}, {1190, 1, -1, 0}// 28	29	30	
			, {1190, 1, 0, 0}, {1190, 1, 1, 0}, {1190, 2, -1, 0}// 31	32	33	
			, {1190, 2, 0, 0}, {1190, 2, 1, 0}, {1487, -2, 2, 20}// 34	35	36	
			, {1487, -1, 2, 20}, {1487, 0, 2, 20}, {1487, 1, 2, 20}// 37	38	39	
			, {1487, 2, 1, 23}, {1487, -2, 1, 23}, {1487, -1, 1, 23}// 40	41	42	
			, {1487, 0, 1, 23}, {1487, 1, 1, 23}, {1487, 3, 2, 20}// 43	44	45	
			, {1487, 3, 1, 23}, {1487, 2, 2, 20}, {1488, -1, 0, 23}// 46	47	48	
			, {1488, -2, 0, 23}, {1488, 0, 0, 23}, {1488, -2, -1, 20}// 49	50	51	
			, {1488, 1, 0, 22}, {1488, -1, -1, 20}, {1488, 2, 0, 23}// 52	53	54	
			, {1488, 0, -1, 20}, {1488, 3, 0, 23}, {1488, 1, -1, 20}// 55	56	57	
			, {1488, 3, -1, 20}, {1488, 2, -1, 20}// 58	59	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new outhouseAddonDeed();
			}
		}

		[ Constructable ]
		public outhouseAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9418, -1, -1, 10, 1153, -1, "Charmin", 1);// 17
			AddComplexComponent( (BaseAddon) this, 5688, 2, 1, 19, 1153, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 4104, 1, -1, 6, 0, -1, "Wash Basin", 1);// 19
			AddComplexComponent( (BaseAddon) this, 14, 0, 1, 0, 0, 1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 15, 2, 0, 0, 0, 1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 15, -3, 0, 0, 0, 1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 14, -2, 1, 0, 0, 1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 14, 1, -2, 0, 0, 1, "", 1);// 64

		}

		public outhouseAddon( Serial serial ) : base( serial )
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

	public class outhouseAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new outhouseAddon();
			}
		}

		[Constructable]
		public outhouseAddonDeed()
		{
			Name = "outhouse";
		}

		public outhouseAddonDeed( Serial serial ) : base( serial )
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