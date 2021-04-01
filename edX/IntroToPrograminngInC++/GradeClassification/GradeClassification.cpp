#include <iostream>
using namespace std;

int main() {
	int grade1,grade2;
  cout << "Please enter two grades seperated by space:\n";
	cin >> grade1 >>grade2;

	if(grade1 < 60 && grade2 < 60){
		cout<<"Student Failed:("<<endl;
	}
	else if(grade1 >= 95 && grade2 >=95){
		cout<<"Student Graduated with Honors:)";
	}
	else 
		cout<<"Student graduated!!!!";
}