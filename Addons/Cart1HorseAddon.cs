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
	public class Cart1HorseAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Cart1HorseAddonDeed();
			}
		}

		[ Constructable ]
		public Cart1HorseAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1 );
			ac.Hue = 1753;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 4117 );
			ac.Hue = 1753;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 1 );
			ac.Hue = 1753;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 4117 );
			ac.Hue = 1753;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 1 );
			ac.Hue = 1753;
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 4117 );
			ac.Hue = 1753;
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 1 );
			ac.Hue = 1753;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 4117 );
			ac.Hue = 1753;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1753;
			AddComponent( ac, -1, -2, 2 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1753;
			AddComponent( ac, -1, -1, 2 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1753;
			AddComponent( ac, -1, 0, 2 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1753;
			AddComponent( ac, -1, 1, 2 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1753;
			AddComponent( ac, 0, -2, 2 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1753;
			AddComponent( ac, 0, -1, 2 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1753;
			AddComponent( ac, 0, 0, 2 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 1753;
			AddComponent( ac, 0, 1, 2 );
			ac = new AddonComponent( 16382 );
			AddComponent( ac, 0, 3, 0 );
			ac = new AddonComponent( 5112 );
			ac.Hue = 1753;
			AddComponent( ac, 0, 3, 4 );
			ac = new AddonComponent( 5112 );
			ac.Hue = 1753;
			AddComponent( ac, -1, 3, 4 );

		}

		public Cart1HorseAddon( Serial serial ) : base( serial )
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

	public class Cart1HorseAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Cart1HorseAddon();
			}
		}

		[Constructable]
		public Cart1HorseAddonDeed()
		{
			Name = "Cart1Horse";
		}

		public Cart1HorseAddonDeed( Serial serial ) : base( serial )
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