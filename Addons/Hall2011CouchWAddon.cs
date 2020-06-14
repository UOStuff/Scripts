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
	public class Hall2011CouchWAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Hall2011CouchWAddonDeed();
			}
		}

		[ Constructable ]
		public Hall2011CouchWAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 4635 );
			ac.Hue = 2694;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 2670;
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 16141 );
			ac.Hue = 2694;
			AddComponent( ac, 0, -2, 5 );
			ac = new AddonComponent( 4635 );
			ac.Hue = 2694;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 4635 );
			ac.Hue = 2694;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 2670;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 16141 );
			ac.Hue = 2694;
			AddComponent( ac, 0, 2, 5 );

		}

		public Hall2011CouchWAddon( Serial serial ) : base( serial )
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

	public class Hall2011CouchWAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Hall2011CouchWAddon();
			}
		}

		[Constructable]
		public Hall2011CouchWAddonDeed()
		{
			Name = "Hall2011CouchW";
		}

		public Hall2011CouchWAddonDeed( Serial serial ) : base( serial )
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