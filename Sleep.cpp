// Sleep for 9s, if time passed <7.5s, then exit
int main(int argc, char** argv) {
	ULONGLONG uptimebeforesleep = GetTickCount64();
	LARGE_INTEGER Interval;
	Interval.QuadPart = -90000000;
	NtDelayExecution(FALSE, &Interval);
	ULONGLONG uptimeaftersleep = GetTickCount64();
	
	if (uptimeaftersleep - uptimebeforesleep < 7500) {
		exit(0);
	};
	
}
