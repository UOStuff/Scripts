
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
	public class WitchyCauldronEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {15640, -1, 0, 1}, {3172, 1, 2, 2}, {15640, 2, -1, 1}// 1	2	3	
			, {3200, 1, 1, 1}, {3197, 0, -1, 5}, {3200, 1, 2, 1}// 4	6	7	
			, {3174, 0, 2, 1}, {3201, 0, 2, 1}, {3172, 0, 2, 1}// 9	10	11	
			, {3201, 0, 2, 1}, {15640, 1, -2, 1}, {3199, 0, 1, 1}// 12	15	16	
			, {3201, 1, 1, 0}, {15640, 0, -2, 1}, {3197, 2, -2, 1}// 17	18	19	
			, {15640, -1, -1, 1}, {3200, 0, 1, 1}, {7134, 1, 2, 7}// 20	21	24	
			, {3200, 0, 2, 1}, {3201, 1, 2, 0}, {3199, 1, 2, 1}// 26	29	30	
			, {3172, 0, 2, 1}, {3174, 1, 1, 1}, {3174, 1, 2, 1}// 31	32	33	
			, {15640, 2, 0, 1}, {3199, 0, 2, 1}, {3197, 1, -2, 0}// 34	35	39	
			, {3199, 1, 1, 1}// 40	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WitchyCauldronEastAddonDeed();
			}
		}

		[ Constructable ]
		public WitchyCauldronEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2541, 2, 3, 20, 1260, -1, "a cauldron", 1);// 5
			AddComplexComponent( (BaseAddon) this, 2918, 0, 3, 1, 1260, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 5333, 1, 0, 1, 1260, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 5315, 0, -1, 1, 1260, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 6571, 1, 2, 11, 0, 29, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 5332, 0, 0, 1, 1260, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 2912, 2, 1, 1, 1260, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 2911, 2, 2, 1, 1260, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 5318, 1, -1, 1, 1260, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 2917, 1, 3, 1, 1260, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 2911, -1, 2, 1, 1260, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 2912, -1, 1, 1, 1260, -1, "", 1);// 38

		}

		public WitchyCauldronEastAddon( Serial serial ) : base( serial )
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

	public class WitchyCauldronEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WitchyCauldronEastAddon();
			}
		}

		[Constructable]
		public WitchyCauldronEastAddonDeed()
		{
			Name = "WitchyCauldronEast";
		}

		public WitchyCauldronEastAddonDeed( Serial serial ) : base( serial )
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