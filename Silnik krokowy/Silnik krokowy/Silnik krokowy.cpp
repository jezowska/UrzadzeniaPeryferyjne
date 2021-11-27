#include <windows.h>
#include <iostream>
#include "FTD2XXh.h"
#pragma comment(lib, "ftd2xx.lib")
using namespace std;

FT_STATUS ftStatus;
int n = 0;
int choice = 0;int mode;int time;int pos = 0;char full[] = { 0b11111010, 0b11110110, 0b11110101, 0b11111001 };
char wave[] = { 0b11110111, 0b11111101, 0b11111011, 0b11111110 };
char half[] = { 0b11111010, 0b11111000, 0b11111001, 0b11110001, 0b11110101, 0b11110100, 0b11110110, 0b11110010 };

void update(char x[], FT_HANDLE ftHandle)
{
	DWORD ByteWritten = 0;
	if (mode == 1 || mode == 2)
	{
		ftStatus = FT_Write(ftHandle, &x[pos % 4], 1, &ByteWritten);
	}
	else
	{
		ftStatus = FT_Write(ftHandle, &x[pos % 8], 1, &ByteWritten);
	}
	
}

void menuSwitch(FT_HANDLE);
void menu(FT_HANDLE ftHandle)
{
	if (mode == 1)
		cout << "1. Wybor sterowania. Aktualnie wybrane -  krokowe" << endl;
	else if (mode == 2) 
		cout << "1. Wybor sterowania. Aktualnie wybrane - falowe" << endl;
	else if (mode == 3) 
		cout << "1. Wybor sterowania. Aktualnie wybrane - polkrokowe" << endl;
	else 
		cout << "1. Wybor sterowania. Aktualnie wybrane - brak" << endl;

	
	cout << "2. Wybor odstepu pomiedzy krokami [" << time << "ms] " << endl;
	cout << "3. Wybor ilosci krokow. Aktualnie wybrana ilosc - " << n << endl;
	cout << "4. Kroki w prawo ("<< n <<")" << endl;
	cout << "5. Kroki w lewo (" << n << ")" << endl;
	cout << "6. Koniec " << endl;
	cout << "7. Wyswietlanie EEPROM. " << endl;
	cin >> choice;
	menuSwitch(ftHandle);
}
void menuSwitch(FT_HANDLE ftHandle)
{
	switch (choice)
	{
	case 1:
	{
		cout << "1. Krokowe" << endl;
		cout << "2. Falowe" << endl;
		cout << "3. Polkrokowe" << endl;
		int c = 0;
		cin >> c;
		while (c > 3 && c < 1)
		{
			cout << "Podaj poprawne sterowanie" << endl;
			cin >> c;
		}
		mode = c;
		break;
	}
	case 2:
	{
		cin >> time;
		break;
	}
	case 3:
	{
		cin >> n;
		break;
	}
	case 4:
	{
		if (mode == 1)
		{
			for (int i = 0; i < n; i++)
			{
				pos++;
				update(full, ftHandle);
				Sleep(time);
			}
		}
		else if (mode == 2)
		{
			for (int i = 0; i < n; i++)
			{
				pos++;
				update(wave, ftHandle);
				Sleep(time);
			}
		}
		else if (mode == 3)
		{
			for (int i = 0; i < n; i++)
			{
				pos++;
				update(half, ftHandle);
				Sleep(time);
			}
		}

		break;
	}
	case 5:
	{
		if (mode == 1)
		{
			for (int i = n; i > 0; i--)
			{
				pos--;
				update(full, ftHandle);
				Sleep(time);
			}
		}
		else if (mode == 2)
		{
			for (int i = n; i > 0; i--)
			{
				pos--;
				update(wave, ftHandle);
				Sleep(time);
			}
		}
		else if (mode == 3)
		{
			for (int i = n; i > 0; i--)
			{
				pos--;
				update(half, ftHandle);
				Sleep(time);
			}
		}
		break;
	}
	case 6:
	{
		if (ftStatus == FT_OK) {
			// FT_Open OK, use ftHandle to access device
			// when finished, call FT_Close
			FT_Close(ftHandle);
		}
		else {
			// FT_Open failed
			cout << "Nie jest dobrze" << endl;
		}
		return;
	}
	case 7:
	{
		FT_PROGRAM_DATA ftData;		char ManufacturerBuf[32];
		char ManufacturerIdBuf[16];
		char DescriptionBuf[64];
		char SerialNumberBuf[16];
		ftData.Signature1 = 0x00000000;
		ftData.Signature2 = 0xffffffff;
		ftData.Version = 0x00000005; // EEPROM structure with FT232H extensions
		ftData.Manufacturer = ManufacturerBuf;
		ftData.ManufacturerId = ManufacturerIdBuf;
		ftData.Description = DescriptionBuf;
		ftData.SerialNumber = SerialNumberBuf;		ftStatus = FT_EE_Read(ftHandle, &ftData);		if (ftStatus == FT_OK)		{			cout << "Manufacturer: " << ftData.Manufacturer << endl;			cout << "ManufacturerId: " << ftData.ManufacturerId << endl;			cout << "Description: " << ftData.Description << endl;			cout << "SerialNumber: " << ftData.SerialNumber << endl;		}
		system("Pause");
		break;
	}
	}
	system("cls");
}


int main()
{
	FT_HANDLE ftHandle;

	ftStatus = FT_Open(0, &ftHandle);
	if (ftStatus == FT_OK) {
		// FT_Open OK, use ftHandle to access device
		cout << "Ok" << endl;
		ftStatus = FT_SetBitMode(ftHandle, 0xff, 0xff);
	}
	else {
		cout << "Nie ok" << endl;
		return -1;
		// FT_Open failed
	}				while (true)
	{
		menu(ftHandle);
	}
	

	return 0;
}
