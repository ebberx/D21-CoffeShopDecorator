namespace CoffeShop {
	class Program {

		public static void Main(String[] args) {
			Beverage b = new HouseBlend();
			Console.WriteLine(b.Cost() + " | " + b.GetDescription());

			b = new Whip(b);
			Console.WriteLine(b.Cost() + " | " + b.GetDescription());

			b = new Sugar(b);
			Console.WriteLine(b.Cost() + " | " + b.GetDescription());

			/* 
				3.a | Give an example of being open to extensions (with code)
			
				The decorator pattern is open to extension the way that the programmer can easily add new decorators.
				An example could be the addition of an OatMilk decorator. It would look like the following:

				public class OatMilk : Decorator {
					Beverage b;

					public OatMilk(Beverage b) { this.b = b; }
					public override double Cost() { return b.Cost() + 0.2; }
					public override string GetDescription() { return "Oat milk"; }
				}
				
				Another example could be extending already existing decorators with additional functionality:

				public class PrintDescriptionBeverageDecorator : Whip {
					public PrintDescriptionBeverageDecorator(Beverage b) : base(b) { Console.WriteLine(b.GetDescription()); }
				}
			*/

			/* 
				3.b | Give an example of this design being closed for changes - what cannot be changed?

				Already existing decorator extensions cannot be changed as they already contain methods for their specific decorator behaviour.
				They inherit this behaviour from the Beverage base class. This class cannot be changed, only extended.

				An example could be to change the Beverage class's Cost method to return a float instead of a double. 
				This cannot be done without altering the original code, as the design is closed for changes.
			*/
		}
	}

	public abstract class Beverage {
		public abstract double Cost();
		public abstract string GetDescription();
	}

	public abstract class Decorator : Beverage { }

	public class HouseBlend : Decorator {
		public override double Cost() {
			return 1.2;
		}
		public override string GetDescription() {
			return "The houses chosen coffe blend";
		}
	}
	public class DarkRoast : Decorator {
		public override double Cost() {
			return 1.1;
		}
		public override string GetDescription() {
			return "Dark roasted coffe";
		}
	}
	public class Decaf : Decorator {
		public override double Cost() {
			return 1.4;
		}
		public override string GetDescription() {
			return "Decaffinated coffe";
		}
	}
	public class Whip : Decorator {
		Beverage b;
		public Whip(Beverage b) {
			this.b = b;
		}
		public override double Cost() {
			return b.Cost() + 0.1;
		}
		public override string GetDescription() {
			return "Whipped cream";
		}
	}
	public class Milk : Decorator {
		Beverage b;
		public Milk(Beverage b) {
			this.b = b;
		}
		public override double Cost() {
			return b.Cost() + 0.15;
		}
		public override string GetDescription() {
			return "Milk";
		}
	}
	public class Sugar : Decorator {
		Beverage b;
		public Sugar(Beverage b) {
			this.b = b;
		}
		public override double Cost() {
			return b.Cost() + 0.2;
		}
		public override string GetDescription() {
			return "Sugar";
		}
	}
}