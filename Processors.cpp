// If <2 processors exit
int main(int argc, char** argv) {
  
	int minprocs = 2;
	SYSTEM_INFO sysinfo;
	GetSystemInfo(&sysinfo);
	int numprocs = sysinfo.dwNumberOfProcessors;
	if (numprocs < minprocs) {
		exit(0);
	}
  
}
