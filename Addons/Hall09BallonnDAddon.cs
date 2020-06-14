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
	public class Hall09BallonnDAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Hall09BallonnDAddonDeed();
			}
		}

		[ Constructable ]
		public Hall09BallonnDAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 8708 );
			ac.Hue = 2672;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 2572;
			AddComponent( ac, 1, 0, 6 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 2572;
			AddComponent( ac, 0, 1, 6 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 2640;
			AddComponent( ac, 1, 1, 6 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 2632;
			AddComponent( ac, 0, 0, 6 );

		}

		public Hall09BallonnDAddon( Serial serial ) : base( serial )
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

	public class Hall09BallonnDAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Hall09BallonnDAddon();
			}
		}

		[Constructable]
		public Hall09BallonnDAddonDeed()
		{
			Name = "Hall09BallonnD";
		}

		public Hall09BallonnDAddonDeed( Serial serial ) : base( serial )
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