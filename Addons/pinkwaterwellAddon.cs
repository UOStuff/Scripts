
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
	public class pinkwaterwellAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {10552, 0, 0, 0}, {6039, 0, 0, 1}, {10558, 0, -1, 0}// 1	4	5	
			, {10555, -1, 0, 0}, {10562, 0, -1, 5}, {3208, 0, 1, 0}// 6	7	8	
			, {3231, -1, 1, 0}, {10562, -1, -1, 5}, {3377, -1, -1, 6}// 9	10	11	
			, {10562, 0, 0, 5}, {3204, -1, 1, 5}, {10562, -1, 0, 5}// 12	13	14	
			, {3209, 1, 0, 0}, {3239, 1, -1, 0}, {4967, 1, 1, 2}// 15	16	19	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new pinkwaterwellAddonDeed();
			}
		}

		[ Constructable ]
		public pinkwaterwellAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 10513, 0, 0, 16, 1219, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 10513, 0, 1, 16, 1219, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 10511, 1, 1, 16, 1219, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 10511, 1, 0, 16, 1219, -1, "", 1);// 18

		}

		public pinkwaterwellAddon( Serial serial ) : base( serial )
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

	public class pinkwaterwellAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new pinkwaterwellAddon();
			}
		}

		[Constructable]
		public pinkwaterwellAddonDeed()
		{
			Name = "pinkwaterwell";
		}

		public pinkwaterwellAddonDeed( Serial serial ) : base( serial )
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