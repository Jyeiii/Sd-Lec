#include <iostream>
#include <string>
#include <vector>

using namespace std;

// Cake class
class Cake {
private:
    string name;
    string flavor;
    double price;
    vector<string> ingredients;

public:
    Cake(string name, string flavor, double price, vector<string> ingredients) {
        this->name = name;
        this->flavor = flavor;
        this->price = price;
        this->ingredients = ingredients;
    }

    string getName() {
        return name;
    }

    string getFlavor() {
        return flavor;
    }

    double getPrice() {
        return price;
    }

    vector<string> getIngredients() {
        return ingredients;
    }

    double calculatePrice() {
        // Implementation of the method goes here
    }

    void displayIngredients() {
        // Implementation of the method goes here
    }
};

// CakeWebsite class
class CakeWebsite {
private:
    vector<Cake> cakes;

public:
    CakeWebsite() {
        // Add cakes to the list
        cakes.push_back(Cake("Chocolate Cake", "Chocolate", 25.99, {"flour", "sugar", "cocoa powder"}));
        cakes.push_back(Cake("Vanilla Cake", "Vanilla", 22.99, {"flour", "sugar", "vanilla extract"}));
        cakes.push_back(Cake("Strawberry Cake", "Strawberry", 28.99, {"flour", "sugar", "strawberry extract"}));
    }

    Cake searchCake(string name, int start, int end) {
        int mid = (start + end) / 2;
        if (cakes[mid].getName() == name) {
            return cakes[mid];
        } else if (name < cakes[mid].getName()) {
            return searchCake(name, start, mid - 1);
        } else {
            return searchCake(name, mid + 1, end);
        }
    }
};

// Main function
int main() {
    CakeWebsite website;

    // Search for a cake
    Cake cake = website.searchCake("Vanilla Cake", 0, website.cakes.size() - 1);
    cout << "Cake found: " << cake.getName() << endl;
    cout << "Flavor: " << cake.getFlavor() << endl;
    cout << "Price: $" << cake.getPrice() << endl;
    cout << "Ingredients: ";
    for (string ingredient : cake.getIngredients()) {
        cout << ingredient << ", ";
    }
    cout << endl;

    return 0;
}
