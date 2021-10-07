// If system uptime < 600 (10 mins) exit
int main(int argc, char** argv) {
  
	ULONGLONG uptimebeforesleep = GetTickCount64();
	LARGE_INTEGER Interval;
	Interval.QuadPart = -90000000;
	NtDelayExecution(FALSE, &Interval);
	ULONGLONG uptimeaftersleep = GetTickCount64();
	
	if (uptimebeforesleep / 1000 < 600) {
		exit(0);
	}
}
