#include <Windows.h>
#include <iostream>

#include "IPhotoMode.hpp"

// Expanded Photo Mode mod for Shadow of the Tomb Raider (v1.0 build 458.0_64 - Steam)

void InitalizeConsole()
{
    AllocConsole();
    freopen_s((FILE**)stdout, "CONOUT$", "w", stdout);

    CONSOLE_CURSOR_INFO info{ 100, FALSE };
    SetConsoleCursorInfo(GetStdHandle(STD_OUTPUT_HANDLE), &info);

    SetConsoleTitle(L"FoundationGameCamera");

    std::wcout << "Expanded Photo Mode mod for Shadow of the Tomb Raider\n\n";
    std::wcout << "Use R and T to adjust roll\n";
    std::wcout << "Use F and G to adjust fov\n";
    std::wcout << "Use END to unload while not using the photographer mode.";
}

void RemoveConsole()
{
    std::wcout << "\n\nUnloaded";

    FreeConsole();
}

DWORD __stdcall MainThread(HMODULE thisModule)
{
    InitalizeConsole();

    auto iPhotoMode = new Nesae::ExpandedPhotoMode::IPhotoMode;
    
    while (true)
    {
        if (iPhotoMode->IsPhotoMode())
        {
            if (GetAsyncKeyState(0x52)) // R
                iPhotoMode->ChangeRoll(0.1f);

            if (GetAsyncKeyState(0x54)) // T
                iPhotoMode->ChangeRoll(-0.1f);

            if (GetAsyncKeyState(0x46)) // F
                iPhotoMode->ChangeFoV(0.01f);

            if (GetAsyncKeyState(0x47)) // G
                iPhotoMode->ChangeFoV(-0.01f);
        }

        if (GetAsyncKeyState(VK_END))
            break;

        Sleep(10);
    }

    delete iPhotoMode;

    RemoveConsole();
    FreeLibraryAndExitThread(thisModule, 0);
    
    return 0;
}

BOOL __stdcall DllMain(HMODULE hModule, DWORD ul_reason_for_call, LPVOID lpReserved)
{
    switch (ul_reason_for_call)
    {
        case DLL_PROCESS_ATTACH:
        {
            CreateThread(0, 0, (LPTHREAD_START_ROUTINE)MainThread, hModule, 0, 0);
            break;
        }
    }
    return TRUE;
}