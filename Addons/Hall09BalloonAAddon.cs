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
	public class Hall09BalloonAAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Hall09BalloonAAddonDeed();
			}
		}

		[ Constructable ]
		public Hall09BalloonAAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 8708 );
			ac.Hue = 2646;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 2590;
			AddComponent( ac, 1, 0, 6 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 2590;
			AddComponent( ac, 0, 1, 6 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 2640;
			AddComponent( ac, 1, 1, 6 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 2646;
			AddComponent( ac, 0, 0, 6 );

		}

		public Hall09BalloonAAddon( Serial serial ) : base( serial )
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

	public class Hall09BalloonAAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Hall09BalloonAAddon();
			}
		}

		[Constructable]
		public Hall09BalloonAAddonDeed()
		{
			Name = "Hall09BalloonA";
		}

		public Hall09BalloonAAddonDeed( Serial serial ) : base( serial )
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