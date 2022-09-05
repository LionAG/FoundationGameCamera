#include "IPlayer.hpp"
#include <Windows.h>

Nesae::ExpandedPhotoMode::SDK::Player* Nesae::ExpandedPhotoMode::IPlayer::GetInstance()
{
    auto moduleBase = (QWORD)GetModuleHandle(NULL);
    auto instance = *((QWORD*)(moduleBase + 0x14690B8));

    return reinterpret_cast<SDK::Player*>(instance);
}

void Nesae::ExpandedPhotoMode::IPlayer::Rotate(RotationAxis axis, float amount)
{
    switch (axis)
    {
    case Nesae::ExpandedPhotoMode::RotationAxis::X: this->RotateByXAxis(amount); break;
    case Nesae::ExpandedPhotoMode::RotationAxis::Y: this->RotateByYAxis(amount); break;
    case Nesae::ExpandedPhotoMode::RotationAxis::Z: this->RotateByZAxis(amount); break;
    default: break;
    }
}

void Nesae::ExpandedPhotoMode::IPlayer::RotateByXAxis(float amount)
{
    auto xRotation = this->GetInstance()->XRotation;

    xRotation += amount;

    if (xRotation > 0.9f)
        xRotation = 0.9f;

    if (xRotation < -0.9f)
        xRotation = -0.9f;

    this->GetInstance()->XRotation = xRotation;
}

void Nesae::ExpandedPhotoMode::IPlayer::RotateByYAxis(float amount)
{
    auto yRotation = this->GetInstance()->YRotation;

    yRotation += amount;

    if (yRotation > 0.9f)
        yRotation = 0.9f;

    if (yRotation < -0.9f)
        yRotation = -0.9f;

    this->GetInstance()->YRotation = yRotation;
}

void Nesae::ExpandedPhotoMode::IPlayer::RotateByZAxis(float amount)
{
    auto zRotation = this->GetInstance()->ZRotation;

    zRotation += amount;

    if (zRotation > 3.14f)
        zRotation = 3.14f;

    if (zRotation < -3.14f)
        zRotation = -3.14f;

    this->GetInstance()->ZRotation = zRotation;
}
