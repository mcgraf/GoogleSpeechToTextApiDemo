Imports Google.Cloud.Speech.V1
Imports System

Namespace SpeechToTextApiDemo

    Module Module1

        Sub Main()
            Dim speech = SpeechClient.Create()
            Dim config = New RecognitionConfig With {.LanguageCode = LanguageCodes.Greek.Greece, .Model = vbUseDefault}
            Dim audio = RecognitionAudio.FromStorageUri("gs//speech-demo-2/Vocaroo3.wav")
            Dim responce = speech.Recognize(config, audio)
            For Each result In responce.Results
                For Each alternative In result.Alternatives
                    Console.WriteLine(alternative.Transcript)
                Next
            Next
        End Sub

    End Module
End Namespace
