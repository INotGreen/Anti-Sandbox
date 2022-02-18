int main() {
  
    int finalPrime = 0;
    int max = 5000; // ~20sec
    for (int i = 2; i < max; i++) {
        int latestPrime = 0;
        bool prime = true;
        bool first = true;
        for (int j = 2; j * j <= i; j++)
        {
            if (i % j == 0)
            {
                prime = false;
                if (first == true) {
                    first == false;
                    ::ShowWindow(::GetConsoleWindow(), SW_HIDE);
                }
                break;
            }
            std::cout << i;
            finalPrime = i;
        }
    }
}
