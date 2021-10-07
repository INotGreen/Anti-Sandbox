// If <4GB ram exit
int main(int argc, char** argv) {
	
	MEMORYSTATUSEX totram;
	totram.dwLength = sizeof(totram);
	GlobalMemoryStatusEx(&totram);
	if ((float)totram.ullTotalPhys / 1073741824 < 4) {
		exit(0);
	}
}
