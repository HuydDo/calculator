abstract class Bank {
  abstract void getRateOfInterest();
}

class SBI extends Bank {
  void getRateOfInterest(){System.out.println("7%");};
}

class PNB extends Bank {
  void getRateOfInterest(){System.out.println("9%");};
}
class TestBank {
  public static void main(String args[]){
    Bank obj1 = new SBI();
    obj1.getRateOfInterest();
    Bank obj2 = new PNB();
    obj2.getRateOfInterest();
  }
}
