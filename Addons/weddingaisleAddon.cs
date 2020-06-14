
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
	public class weddingaisleAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {9037, -2, -2, 0}, {9037, -2, 1, 0}, {9037, -2, 3, 0}// 7	10	13	
			, {9037, -2, -1, 0}, {9037, -2, 2, 0}, {9037, -2, 0, 0}// 14	19	26	
			, {9037, 2, -2, 0}, {9037, 2, -1, 0}, {9037, 2, 3, 0}// 32	42	44	
			, {9037, 2, 0, 0}, {9037, 2, 1, 0}, {9037, 2, 2, 0}// 48	50	64	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new weddingaisleAddonDeed();
			}
		}

		[ Constructable ]
		public weddingaisleAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3384, -1, -3, 0, 2389, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2766, -1, -3, 0, 2280, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2762, -2, -3, 0, 2280, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 6816, -1, -2, 0, 2280, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2758, -1, -2, 0, 2280, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 2765, -2, -2, 0, 2280, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 3383, -2, -3, 0, 2389, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 4, -1, -3, 0, 2280, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2765, -2, 0, 0, 2280, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2765, -2, 2, 0, 2280, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2758, -1, 1, 0, 2280, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 2765, -2, 3, 0, 2280, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 2765, -2, 1, 0, 2280, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 2758, -1, 3, 0, 2280, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 2765, -2, -1, 0, 2280, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 6816, -1, 4, 0, 2280, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 2763, -2, 4, 0, 2280, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2758, -1, 2, 0, 2280, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 2758, -1, 0, 0, 2280, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 2758, -1, -1, 0, 2280, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 2768, -1, 4, 0, 2280, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 6816, -1, 1, 0, 2280, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 2764, 2, -3, 0, 2280, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 3383, 1, -3, 0, 2389, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 6814, 2, -2, 0, 2280, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 2758, 0, -2, 0, 2280, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 2766, 1, -3, 0, 2280, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 2758, 1, -2, 0, 2280, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 3384, 0, -3, 0, 2389, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 2766, 0, -3, 0, 2280, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 2767, 2, -2, 0, 2280, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 3384, 2, -3, 0, 2389, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 5, 0, -3, 0, 2280, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 2767, 2, 1, 0, 2280, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 2758, 1, 1, 0, 2280, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 2767, 2, -1, 0, 2280, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 2758, 0, 1, 0, 2280, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 2758, 0, 2, 0, 2280, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 2767, 2, 0, 0, 2280, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 2758, 1, 0, 0, 2280, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 2767, 2, 3, 0, 2280, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 2758, 0, 3, 0, 2280, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 2758, 1, 3, 0, 2280, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 2767, 2, 2, 0, 2280, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 2758, 0, 0, 0, 2280, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 2768, 0, 4, 0, 2280, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 6814, 2, 1, 0, 2280, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 2761, 2, 4, 0, 2280, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 2758, 1, -1, 0, 2280, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 2758, 0, -1, 0, 2280, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 2768, 1, 4, 0, 2280, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 2758, 1, 2, 0, 2280, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 6814, 2, 4, 0, 2280, -1, "", 1);// 65

		}

		public weddingaisleAddon( Serial serial ) : base( serial )
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

	public class weddingaisleAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new weddingaisleAddon();
			}
		}

		[Constructable]
		public weddingaisleAddonDeed()
		{
			Name = "weddingaisle";
		}

		public weddingaisleAddonDeed( Serial serial ) : base( serial )
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