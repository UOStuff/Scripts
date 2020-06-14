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
	public class EasterWalkNS1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new EasterWalkNS1AddonDeed();
			}
		}

		[ Constructable ]
		public EasterWalkNS1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1997 );
			ac.Hue = 1890;
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1890;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1890;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1890;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1890;
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1890;
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1890;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1890;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2781;
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2781;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2781;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2781;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2781;
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2781;
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2781;
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2781;
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2781;
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1890;
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1890;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2781;
			AddComponent( ac, -1, 2, 0 );

		}

		public EasterWalkNS1Addon( Serial serial ) : base( serial )
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

	public class EasterWalkNS1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new EasterWalkNS1Addon();
			}
		}

		[Constructable]
		public EasterWalkNS1AddonDeed()
		{
			Name = "EasterWalkNS1";
		}

		public EasterWalkNS1AddonDeed( Serial serial ) : base( serial )
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