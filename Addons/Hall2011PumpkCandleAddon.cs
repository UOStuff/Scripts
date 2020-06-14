/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class Hall2011PumpkCandleAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Hall2011PumpkCandleAddonDeed();
			}
		}

		[ Constructable ]
		public Hall2011PumpkCandleAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 2854 );
			ac.Light = LightType.ArchedWindowEast;
			ac.Hue = 2694;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 0, 0, 14 );
			ac = new AddonComponent( 5703 );
			ac.Light = LightType.Circle150;
			AddComponent( ac, 0, 0, 14 );
			ac = new AddonComponent( 3179 );
			AddComponent( ac, 0, 0, 14 );
			ac = new AddonComponent( 3885 );
			ac.Hue = 1161;
			AddComponent( ac, 0, 0, 13 );
			ac = new AddonComponent( 3871 );
			ac.Hue = 1161;
			AddComponent( ac, 0, 0, 14 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 0, 0, 14 );
			ac = new AddonComponent( 5703 );
			ac.Light = LightType.Circle150;
			AddComponent( ac, 0, 0, 14 );
			ac = new AddonComponent( 3178 );
			AddComponent( ac, 0, 0, 13 );
			ac = new AddonComponent( 3883 );
			ac.Hue = 1161;
			AddComponent( ac, 0, 0, 15 );
			ac = new AddonComponent( 3862 );
			ac.Hue = 1161;
			AddComponent( ac, 0, 0, 14 );
			ac = new AddonComponent( 3180 );
			AddComponent( ac, 0, 0, 18 );

		}

		public Hall2011PumpkCandleAddon( Serial serial ) : base( serial )
		{
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

	public class Hall2011PumpkCandleAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Hall2011PumpkCandleAddon();
			}
		}

		[Constructable]
		public Hall2011PumpkCandleAddonDeed()
		{
			Name = "Hall2011PumpkCandle";
		}

		public Hall2011PumpkCandleAddonDeed( Serial serial ) : base( serial )
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