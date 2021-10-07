// If computer not domain joined, exit
#include <Windows.h>
#include "LM.h"
#pragma comment(lib, "netapi32.lib")

int main(int argc, char** argv) {
  
	PWSTR domainName;
	NETSETUP_JOIN_STATUS status;
	NetGetJoinInformation(NULL, &domainName, &status);
	if (status != NetSetupDomainName) {
		exit(0);
	}
}
