
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
	public class ChaosShrineAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {5347, 0, -1, 0}, {5348, 0, 0, 0}, {5349, 1, 0, 0}// 1	2	3	
			, {5350, 1, -1, 0}, {4, 0, -2, 0}, {5, 1, -2, 0}// 4	5	6	
			, {7369, 0, 1, 0}, {7370, 0, 2, 0}, {7371, 1, 2, 0}// 7	8	9	
			, {7373, -1, 2, 0}, {7374, 1, 3, 0}, {7373, 0, 3, 0}// 10	11	12	
			, {7375, -1, 1, 0}, {7385, 1, 1, 0}, {7383, 2, 0, 0}// 13	14	15	
			, {7384, 2, -1, 0}, {7384, 2, 1, 0}, {7382, 1, -2, 0}// 16	17	18	
			, {7376, 2, -2, 0}, {7374, 2, 2, 0}, {15720, 1, 1, 1}// 19	20	21	
			, {6922, 0, -1, 1}, {7573, 1, -1, 0}, {7407, 0, 1, 0}// 22	23	24	
			, {7107, 1, 2, 1}// 26	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ChaosShrineAddonDeed();
			}
		}

		[ Constructable ]
		public ChaosShrineAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 7408, 2, 1, 1, 1166, -1, "", 1);// 25

		}

		public ChaosShrineAddon( Serial serial ) : base( serial )
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

	public class ChaosShrineAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ChaosShrineAddon();
			}
		}

		[Constructable]
		public ChaosShrineAddonDeed()
		{
			Name = "ChaosShrine";
		}

		public ChaosShrineAddonDeed( Serial serial ) : base( serial )
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