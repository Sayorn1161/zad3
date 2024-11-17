#include <iostream>

int main() {
    int digit1, digit2, digit3, digit4;
    std::cout << "Введіть першу цифру: ";
    std::cin >> digit1;
    std::cout << "Введіть другу цифру: ";
    std::cin >> digit2;
    std::cout << "Введіть третю цифру: ";
    std::cin >> digit3;
    std::cout << "Введіть четверту цифру: ";
    std::cin >> digit4;

    int number = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;
    std::cout << "Сформоване число: " << number << std::endl;

    return 0;
}
