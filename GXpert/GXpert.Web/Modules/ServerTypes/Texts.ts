import { proxyTexts } from "@serenity-is/corelib";

namespace GXpert.Texts {

    export declare namespace Db {

        namespace Activation {

            namespace Activation {
                export const ActivationDate: string;
                export const ActivationLogCode: string;
                export const ActivationLogId: string;
                export const DeviceDetails: string;
                export const DeviceId: string;
                export const EStatus: string;
                export const ExpiryDate: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const PlayListId: string;
                export const PlayListTitle: string;
                export const SerialKeyId: string;
                export const StudentId: string;
                export const StudentName: string;
                export const TeacherId: string;
                export const TeacherPrn: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ActivationLog {
                export const Code: string;
                export const DeviceDetails: string;
                export const DeviceId: string;
                export const EStatus: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Note: string;
                export const PlayListId: string;
                export const PlayListTitle: string;
                export const SerialKey: string;
                export const TeacherId: string;
                export const TeacherPrn: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace CouponCode {
                export const Code: string;
                export const ConsumedCount: string;
                export const Count: string;
                export const CountType: string;
                export const CouponValidityDate: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const PlayListId: string;
                export const PlayListTitle: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const ValidDate: string;
                export const ValidityInDays: string;
                export const ValidityType: string;
            }

            namespace PreDefinedKey {
                export const EStatus: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const SerialKey: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace SerialKey {
                export const EStatus: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Note: string;
                export const PlayListId: string;
                export const PlayListTitle: string;
                export const SerialKey: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const ValidDate: string;
                export const ValidityInDays: string;
                export const ValidityType: string;
            }
        }

        namespace Administration {

            namespace Language {
                export const Id: string;
                export const LanguageId: string;
                export const LanguageName: string;
            }

            namespace Role {
                export const RoleId: string;
                export const RoleKey: string;
                export const RoleKeyOrName: string;
                export const RoleName: string;
            }

            namespace RolePermission {
                export const PermissionKey: string;
                export const RoleId: string;
                export const RoleKeyOrName: string;
                export const RolePermissionId: string;
            }

            namespace User {
                export const DisplayName: string;
                export const Email: string;
                export const ImpersonationToken: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LastDirectoryUpdate: string;
                export const MobilePhoneNumber: string;
                export const MobilePhoneVerified: string;
                export const Password: string;
                export const PasswordConfirm: string;
                export const PasswordHash: string;
                export const PasswordSalt: string;
                export const Roles: string;
                export const Source: string;
                export const TwoFactorAuth: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const UserImage: string;
                export const Username: string;
            }

            namespace UserPermission {
                export const Granted: string;
                export const PermissionKey: string;
                export const User: string;
                export const UserId: string;
                export const UserPermissionId: string;
                export const Username: string;
            }

            namespace UserRole {
                export const RoleId: string;
                export const RoleKeyOrName: string;
                export const User: string;
                export const UserId: string;
                export const UserRoleId: string;
                export const Username: string;
            }
        }

        namespace Analytics {

            namespace AnalyticsLog {
                export const ActivationDeviceId: string;
                export const ActivationId: string;
                export const ContentId: string;
                export const ContentTitle: string;
                export const EndDateTime: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const StartDatetime: string;
                export const StudentId: string;
                export const StudentPrn: string;
                export const TimeSpent: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace AssignedExamTeachers {
                export const ExamId: string;
                export const ExamTitle: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const PlayListId: string;
                export const PlayListTitle: string;
                export const TeacherId: string;
                export const TeacherPrn: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ExamAttempt {
                export const ActivationDeviceId: string;
                export const ActivationId: string;
                export const EStatus: string;
                export const ExamId: string;
                export const ExamTitle: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const PlayListId: string;
                export const PlayListTitle: string;
                export const StudentAnswerSheetUpload: string;
                export const StudentId: string;
                export const StudentPrn: string;
                export const TeacherCheckedPaperUpload: string;
                export const TeacherId: string;
                export const TeacherPrn: string;
                export const TimeSpent: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ExamAttemptQuestion {
                export const Attemptstatus: string;
                export const ExamAttemptId: string;
                export const ExamAttemptStudentAnswerSheetUpload: string;
                export const ExamQuestionId: string;
                export const ExamQuestionRightAnswer: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const MarksObtained: string;
                export const OptionSelected: string;
                export const OutOfmarks: string;
                export const Result: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }
        }

        namespace Attendance {

            namespace AssignmentAttempt {
                export const ActivationDeviceId: string;
                export const ActivationId: string;
                export const AssignmentId: string;
                export const AssignmentTitle: string;
                export const EStatus: string;
                export const FileUploaded: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const PlayListId: string;
                export const PlayListTitle: string;
                export const StudentId: string;
                export const StudentPrn: string;
                export const TeacherId: string;
                export const TeacherPrn: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace AssignmentAttemptEvaluation {
                export const AssignmentAttemptFileUploaded: string;
                export const AssignmentAttemptId: string;
                export const AssignmentEvaluationEvalutionCriteria: string;
                export const AssignmentEvaluationId: string;
                export const AssignmentId: string;
                export const AssignmentTitle: string;
                export const EvaluationStatus: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const MarksObtained: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace PollResponse {
                export const ActivationDeviceId: string;
                export const ActivationId: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LiveSessionLogId: string;
                export const PollId: string;
                export const PollQuestion: string;
                export const Response: string;
                export const ResponseTimeInSeconds: string;
                export const Score: string;
                export const StudentId: string;
                export const StudentPrn: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace RaiseHandLiveSession {
                export const ActivationDeviceId: string;
                export const ActivationId: string;
                export const HandRaiseStatus: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LiveSessionlogId: string;
                export const PlayListId: string;
                export const PlayListTitle: string;
                export const SessionTime: string;
                export const StudentId: string;
                export const StudentPrn: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace RaiseHandRecordedSession {
                export const ActivationDeviceId: string;
                export const ActivationId: string;
                export const ContentId: string;
                export const ContentTitle: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const PlayListContentId: string;
                export const PlayListId: string;
                export const PlayListTitle: string;
                export const StudentId: string;
                export const StudentPrn: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }
        }

        namespace Content {

            namespace Content {
                export const Description: string;
                export const DisLikesCount: string;
                export const EContentType: string;
                export const EDifficultyLevel: string;
                export const FileKeyUrl: string;
                export const FilePath: string;
                export const FilePathFallBack1: string;
                export const FilePathFallBack2: string;
                export const HandRaiseCount: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Iv: string;
                export const Length: string;
                export const LikesCount: string;
                export const MediaInfo: string;
                export const NumberOfPages: string;
                export const Poster: string;
                export const SearchTags: string;
                export const Size: string;
                export const ThumbNail: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ContentAudio {
                export const ContentId: string;
                export const ContentTitle: string;
                export const FileKeyUrl: string;
                export const HlsFile: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Iv: string;
                export const LanguageId: string;
                export const LanguageName: string;
                export const MediaFile: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const Username: string;
            }

            namespace ContentBloomsIndex {
                export const BloomsIndex: string;
                export const BloomsIndexCoginitiveSkill: string;
                export const ContentId: string;
                export const ContentTitle: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const Weightage: string;
            }

            namespace ContentCategory {
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const IsGlobal: string;
                export const ListingThumbnail: string;
                export const MediaCount: string;
                export const Name: string;
                export const Thumbnail: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ContentComment {
                export const CommentLeft: string;
                export const CommentLevel: string;
                export const CommentRight: string;
                export const CommentText: string;
                export const ContentId: string;
                export const ContentTitle: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const ParentCommentText: string;
                export const ParentId: string;
                export const TreeId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const Username: string;
            }

            namespace ContentCourse {
                export const ClassId: string;
                export const ClassTitle: string;
                export const ContentId: string;
                export const ContentTitle: string;
                export const CourseId: string;
                export const CourseTitle: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const SemesterId: string;
                export const SemesterTitle: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const Username: string;
            }

            namespace ContentLanguage {
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Name: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ContentLicense {
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Name: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ContentMediaRating {
                export const ContentId: string;
                export const ContentTitle: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const RatingId: string;
                export const RatingName: string;
                export const Score: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const Username: string;
            }

            namespace ContentRating {
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Name: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ContentSubtitle {
                export const ContentId: string;
                export const ContentTitle: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LanguageId: string;
                export const LanguageName: string;
                export const SubtitleFile: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const Username: string;
            }

            namespace ContentTopic {
                export const ClassId: string;
                export const ClassTitle: string;
                export const ContentId: string;
                export const ContentTitle: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const MediumId: string;
                export const MediumTitle: string;
                export const SortOrder: string;
                export const SubjectId: string;
                export const SubjectTitle: string;
                export const TopicId: string;
                export const TopicTitle: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }
        }

        namespace Exams {

            namespace Assignment {
                export const ClassId: string;
                export const ClassTitle: string;
                export const Description: string;
                export const File: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const SubjectId: string;
                export const SubjectTitle: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace AssignmentEvaluation {
                export const AssignmentId: string;
                export const AssignmentTitle: string;
                export const BloomsIndex: string;
                export const BloomsIndexCoginitiveSkill: string;
                export const BloomsWeightage: string;
                export const ClassId: string;
                export const ClassTitle: string;
                export const EvalutionCriteria: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const SubjectId: string;
                export const SubjectTitle: string;
                export const TopicId: string;
                export const TopicTitle: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace Exam {
                export const EExamNavigation: string;
                export const EExamState: string;
                export const EExamType: string;
                export const EOptionDisplayType: string;
                export const EQuestionNavigation: string;
                export const EResultType: string;
                export const ESectionNavigation: string;
                export const ExamDuration: string;
                export const HasNegativeMarketing: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const Instructions: string;
                export const IsActive: string;
                export const MaxMarks: string;
                export const ModelAnswerPaperPath: string;
                export const NegativeMarks: string;
                export const QuestionPaperPath: string;
                export const SearchTags: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ExamQuestion {
                export const ClassId: string;
                export const ClassTitle: string;
                export const EDifficultyLevel: string;
                export const ExamId: string;
                export const ExamSectionId: string;
                export const ExamSectionTitle: string;
                export const ExamTitle: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Marks: string;
                export const QuestionId: string;
                export const QuestionText: string;
                export const RightAnswer: string;
                export const SortOrder: string;
                export const SubjectId: string;
                export const SubjectTitle: string;
                export const TopicId: string;
                export const TopicTitle: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ExamSection {
                export const DurationInSeconds: string;
                export const ExamId: string;
                export const ExamTitle: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const Instructions: string;
                export const IsActive: string;
                export const NumberOfMandatoryQuestions: string;
                export const NumberOfQuestions: string;
                export const ParentId: string;
                export const ParentTitle: string;
                export const SearchTags: string;
                export const SortOrder: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }
        }

        namespace Institute {

            namespace Branch {
                export const BranchCode: string;
                export const DepartmentId: string;
                export const DepartmentTitle: string;
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const InstituteId: string;
                export const InstituteName: string;
                export const IsActive: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace Department {
                export const Description: string;
                export const HODName: string;
                export const HodId: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const InstituteId: string;
                export const InstituteName: string;
                export const IsActive: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace Institute {
                export const Address: string;
                export const City: string;
                export const Description: string;
                export const DistrictId: string;
                export const DistrictTitle: string;
                export const EType: string;
                export const EstablishmentDate: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LocationInfo: string;
                export const Name: string;
                export const PrincipalId: string;
                export const PrincipalName: string;
                export const StateId: string;
                export const StateTitle: string;
                export const TalukaId: string;
                export const TalukaTitle: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace InstituteDivision {
                export const AcademicYearId: string;
                export const AcademicYearName: string;
                export const ClassId: string;
                export const ClassTeacherId: string;
                export const ClassTeacherPrn: string;
                export const ClassTitle: string;
                export const CourseId: string;
                export const CourseTitle: string;
                export const DepartmentId: string;
                export const DepartmentTitle: string;
                export const Division: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const InstituteId: string;
                export const InstituteName: string;
                export const IsActive: string;
                export const SemesterId: string;
                export const SemesterTitle: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace InstituteStudent {
                export const AcademicYearId: string;
                export const AcademicYearName: string;
                export const ClassId: string;
                export const ClassTitle: string;
                export const Description: string;
                export const Division: string;
                export const EndDate: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const InstituteDivisionId: string;
                export const InstituteId: string;
                export const InstituteName: string;
                export const IsActive: string;
                export const RollNumber: string;
                export const Semester: string;
                export const SemesterId: string;
                export const StartDate: string;
                export const StudentId: string;
                export const StudentPrn: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace InstituteTeacher {
                export const AcademicYearId: string;
                export const AcademicYearName: string;
                export const ClassId: string;
                export const ClassTitle: string;
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const InstituteDivision: string;
                export const InstituteDivisionId: string;
                export const InstituteId: string;
                export const InstituteName: string;
                export const IsActive: string;
                export const Semester: string;
                export const SemesterId: string;
                export const SubjectId: string;
                export const SubjectTitle: string;
                export const TeacherId: string;
                export const TeacherPrn: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace InstituteTimeTable {
                export const ClassRoomNo: string;
                export const Date: string;
                export const EType: string;
                export const EndTime: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const InstituteClassDivision: string;
                export const InstituteDivisionId: string;
                export const IsActive: string;
                export const PeriodIndex: string;
                export const StartTime: string;
                export const TeacherId: string;
                export const TeacherPrn: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }
        }

        namespace LiveSessions {

            namespace LiveSession {
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LiveAdditionalInfo: string;
                export const LiveProvider: string;
                export const MeetingId: string;
                export const Password: string;
                export const SearchTags: string;
                export const Secret: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace LiveSessionLog {
                export const ClassId: string;
                export const ClassTitle: string;
                export const Date: string;
                export const EndTime: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const StartTime: string;
                export const SubjectId: string;
                export const SubjectTitle: string;
                export const TeacherId: string;
                export const TeacherPrn: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace Poll {
                export const AverageResponseTime: string;
                export const BloomsTaxonomyCoginitiveSkill: string;
                export const BloomsTaxonomyId: string;
                export const EQuestionType: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LiveSessionLogId: string;
                export const NumberOfCorrect: string;
                export const NumberOfWrong: string;
                export const Option1: string;
                export const Option2: string;
                export const Option3: string;
                export const Option4: string;
                export const Option5: string;
                export const Question: string;
                export const RightAnswer: string;
                export const TotalAttempts: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const Weightage: string;
            }
        }

        namespace Masters {

            namespace AcademicPerformance {
                export const AcademicYearId: string;
                export const AcademicYearName: string;
                export const ClassId: string;
                export const ClassTitle: string;
                export const CourseId: string;
                export const CourseTitle: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const MarksObtained: string;
                export const OutOfMarks: string;
                export const Remarks: string;
                export const SemesterId: string;
                export const SemesterTitle: string;
                export const StudentId: string;
                export const StudentPrn: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace AcademicSubjectPerformance {
                export const AcademicYearId: string;
                export const AcademicYearName: string;
                export const ClassId: string;
                export const ClassTitle: string;
                export const CourseId: string;
                export const CourseTitle: string;
                export const ETypeOfExam: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const MarksObtained: string;
                export const OutOfMarks: string;
                export const Remarks: string;
                export const SemesterId: string;
                export const SemesterTitle: string;
                export const StudentId: string;
                export const StudentPrn: string;
                export const SubjectId: string;
                export const SubjectTitle: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace AcademicYear {
                export const Description: string;
                export const EndDate: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Name: string;
                export const StartDate: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace BloomsTaxanomy {
                export const CoginitiveSkill: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const SortOrder: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace District {
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const ShortName: string;
                export const StateId: string;
                export const StateTitle: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace PreAcademic {
                export const Description: string;
                export const ExamName: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Thumbnail: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace PreAcademicScore {
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const MarksObtained: string;
                export const OutOfMarks: string;
                export const PassedOutDate: string;
                export const PreAcadamicsExamName: string;
                export const PreAcadamicsId: string;
                export const Remarks: string;
                export const StudentId: string;
                export const StudentPrn: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace Project {
                export const ClassId: string;
                export const ClassTitle: string;
                export const CourseId: string;
                export const CourseTitle: string;
                export const Description: string;
                export const EType: string;
                export const Id: string;
                export const SemesterId: string;
                export const SemesterTitle: string;
                export const StudentId: string;
                export const StudentPrn: string;
                export const Title: string;
            }

            namespace ProjectSkill {
                export const Id: string;
                export const ProjectId: string;
                export const ProjectTitle: string;
                export const SkillCategoryId: string;
                export const SkillCategoryName: string;
                export const SkillId: string;
                export const SkillName: string;
            }

            namespace State {
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const ShortName: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace Taluka {
                export const DistrictId: string;
                export const DistrictTitle: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const ShortName: string;
                export const StateId: string;
                export const StateTitle: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace UserAcademic {
                export const AcademicYearId: string;
                export const AcademicYearName: string;
                export const Description: string;
                export const Id: string;
                export const IsVerify: string;
                export const StudentId: string;
                export const StudentPrn: string;
                export const Title: string;
                export const VerifyBy: string;
            }

            namespace UserSkillsScore {
                export const Id: string;
                export const Score: string;
                export const SkillCategoryId: string;
                export const SkillCategoryName: string;
                export const SkillId: string;
                export const SkillName: string;
            }
        }

        namespace Playlist {

            namespace Module {
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const ParentId: string;
                export const ParentTitle: string;
                export const SortOrder: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace PlayList {
                export const ClassId: string;
                export const ClassTitle: string;
                export const CourseId: string;
                export const CourseTitle: string;
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const PlayListFilePath: string;
                export const PlayListVersion: string;
                export const SemesterId: string;
                export const SemesterName: string;
                export const SubjectId: string;
                export const SubjectTitle: string;
                export const TeacherId: string;
                export const TeacherPrn: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace PlayListContent {
                export const AssignmentId: string;
                export const AssignmentTitle: string;
                export const ContentId: string;
                export const ContentTitle: string;
                export const EContentType: string;
                export const EPublishStatus: string;
                export const ExamId: string;
                export const ExamTitle: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LiveSessionId: string;
                export const LiveSessionMeetingId: string;
                export const ModuleId: string;
                export const ModuleTitle: string;
                export const PlayListId: string;
                export const PlayListTitle: string;
                export const SortOrder: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }
        }

        namespace QuestionBank {

            namespace CommonData {
                export const CommonData: string;
                export const CommonDataTitle: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace Question {
                export const BloomsIndex: string;
                export const BloomsIndexCoginitiveSkill: string;
                export const BloomsWeightage: string;
                export const ClassId: string;
                export const ClassTitle: string;
                export const EDifficultyLevel: string;
                export const EQuestionType: string;
                export const Explaination: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const IsSubjective: string;
                export const QuestionCommonDataCommonDataTitle: string;
                export const QuestionCommonDataId: string;
                export const QuestionCommonDataSortOrder: string;
                export const QuestionOptions: string;
                export const QuestionText: string;
                export const SubjectId: string;
                export const SubjectTitle: string;
                export const TopicId: string;
                export const TopicTitle: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace QuestionCourse {
                export const ClassId: string;
                export const ClassTitle: string;
                export const CourseId: string;
                export const CourseTitle: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const QuestionId: string;
                export const QuestionText: string;
                export const SemesterId: string;
                export const SemesterTitle: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const Username: string;
            }

            namespace QuestionOption {
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const IsCorrect: string;
                export const OptionText: string;
                export const QuestionId: string;
                export const QuestionText: string;
                export const SortOrder: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const Weightage: string;
            }
        }

        namespace Settings {

            namespace Notification {
                export const CreatedOnUtc: string;
                export const HasError: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Message: string;
                export const NotificationGuid: string;
                export const Result: string;
                export const SentOnUtc: string;
                export const SentTries: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace Sms {
                export const ApiKey: string;
                export const EntityId: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Sender: string;
                export const TemplateId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace Smtp {
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const IsSsl: string;
                export const Password: string;
                export const Port: string;
                export const Server: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const Username: string;
            }

            namespace Storage {
                export const AccessKeyId: string;
                export const BucketName: string;
                export const Endpoint: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const IsDefault: string;
                export const Region: string;
                export const S3Types: string;
                export const SecretAccessKey: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UploadPath: string;
                export const UrlPreview: string;
            }
        }

        namespace Skills {

            namespace Skill {
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Name: string;
                export const SkillCategoryId: string;
                export const SkillCategoryName: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace SkillCategory {
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Name: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }
        }

        namespace Syllabus {

            namespace Class {
                export const CourseId: string;
                export const CourseName: string;
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const SortOrder: string;
                export const Thumbnail: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const Weightage: string;
            }

            namespace Course {
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const SortOrder: string;
                export const Thumbnail: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace Medium {
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace Semester {
                export const ClassId: string;
                export const ClassTitle: string;
                export const CourseId: string;
                export const CourseTitle: string;
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const SortOrder: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace Subject {
                export const ClassId: string;
                export const ClassTitle: string;
                export const CourseId: string;
                export const CourseName: string;
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const SemesterId: string;
                export const SemesterName: string;
                export const SortOrder: string;
                export const Thumbnail: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const Weightage: string;
            }

            namespace Topic {
                export const ClassId: string;
                export const ClassTitle: string;
                export const CourseId: string;
                export const CourseName: string;
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const SemesterId: string;
                export const SemesterName: string;
                export const SortOrder: string;
                export const SubjectId: string;
                export const SubjectTitle: string;
                export const Thumbnail: string;
                export const Title: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const Weightage: string;
            }
        }

        namespace Users {

            namespace Hod {
                export const DistrictId: string;
                export const DistrictTitle: string;
                export const Dob: string;
                export const Email: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const InstituteId: string;
                export const InstituteName: string;
                export const IsActive: string;
                export const Mobile: string;
                export const Name: string;
                export const StateId: string;
                export const StateTitle: string;
                export const TalukaId: string;
                export const TalukaTitle: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const Username: string;
            }

            namespace Principal {
                export const DistrictId: string;
                export const DistrictTitle: string;
                export const Dob: string;
                export const Email: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const InstituteId: string;
                export const InstituteName: string;
                export const IsActive: string;
                export const Mobile: string;
                export const Name: string;
                export const StateId: string;
                export const StateTitle: string;
                export const TalukaId: string;
                export const TalukaTitle: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const Username: string;
            }

            namespace Student {
                export const AcademicYearName: string;
                export const AddressLine1: string;
                export const AddressLine2: string;
                export const BranchId: string;
                export const BranchTitle: string;
                export const ClassId: string;
                export const ClassTitle: string;
                export const CourseId: string;
                export const CourseTitle: string;
                export const CurrentAcademicYearId: string;
                export const DepartmentId: string;
                export const DepartmentTitle: string;
                export const Description: string;
                export const DistrictId: string;
                export const DistrictTitle: string;
                export const DivisionId: string;
                export const Dob: string;
                export const Email: string;
                export const Gender: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const InstituteDivision: string;
                export const InstituteId: string;
                export const InstituteName: string;
                export const IsActive: string;
                export const Mobile: string;
                export const Name: string;
                export const Prn: string;
                export const SemesterId: string;
                export const SemesterTitle: string;
                export const StateId: string;
                export const StateTitle: string;
                export const TalukaId: string;
                export const TalukaTitle: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const Username: string;
            }

            namespace Teacher {
                export const Description: string;
                export const DistrictId: string;
                export const DistrictTitle: string;
                export const Dob: string;
                export const Email: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const InstituteId: string;
                export const InstituteName: string;
                export const IsActive: string;
                export const Mobile: string;
                export const Name: string;
                export const Prn: string;
                export const StateId: string;
                export const StateTitle: string;
                export const TalukaId: string;
                export const TalukaTitle: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const Username: string;
            }
        }
    }

    export declare namespace Forms {

        namespace Membership {

            namespace Login {
                export const ForgotPassword: string;
                export const LoginToYourAccount: string;
                export const OR: string;
                export const RememberMe: string;
                export const SignInButton: string;
                export const SignInWithGeneric: string;
                export const SignUpButton: string;
            }

            namespace SendActivation {
                export const FormInfo: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace SignUp {
                export const ActivateEmailSubject: string;
                export const ActivationCompleteMessage: string;
                export const ConfirmDetails: string;
                export const ConfirmEmail: string;
                export const ConfirmPassword: string;
                export const DisplayName: string;
                export const Email: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const Password: string;
                export const SubmitButton: string;
                export const Success: string;
            }
        }
        export const SiteTitle: string;
    }

    export declare namespace Navigation {
        export const Dashboard: string;
        export const LogoutLink: string;
        export const SiteTitle: string;
    }

    export declare namespace Site {

        namespace AccessDenied {
            export const ClickToChangeUser: string;
            export const ClickToLogin: string;
            export const LackPermissions: string;
            export const NotLoggedIn: string;
            export const PageTitle: string;
        }

        namespace Layout {
            export const Language: string;
            export const Theme: string;
        }

        namespace RolePermissionDialog {
            export const DialogTitle: string;
            export const EditButton: string;
            export const SaveSuccess: string;
        }

        namespace UserDialog {
            export const EditPermissionsButton: string;
            export const EditRolesButton: string;
        }

        namespace UserPermissionDialog {
            export const DialogTitle: string;
            export const Grant: string;
            export const Permission: string;
            export const Revoke: string;
            export const SaveSuccess: string;
        }

        namespace ValidationError {
            export const Title: string;
        }
    }

    export declare namespace Validation {
        export const AuthenticationError: string;
        export const CurrentPasswordMismatch: string;
        export const DeleteForeignKeyError: string;
        export const EmailConfirm: string;
        export const EmailInUse: string;
        export const InvalidActivateToken: string;
        export const InvalidResetToken: string;
        export const MinRequiredPasswordLength: string;
        export const PasswordConfirmMismatch: string;
        export const SavePrimaryKeyError: string;
    }

    GXpert['Texts'] = proxyTexts(Texts, '', {
        Db: {
            Activation: {
                Activation: {},
                ActivationLog: {},
                CouponCode: {},
                PreDefinedKey: {},
                SerialKey: {}
            },
            Administration: {
                Language: {},
                Role: {},
                RolePermission: {},
                User: {},
                UserPermission: {},
                UserRole: {}
            },
            Analytics: {
                AnalyticsLog: {},
                AssignedExamTeachers: {},
                ExamAttempt: {},
                ExamAttemptQuestion: {}
            },
            Attendance: {
                AssignmentAttempt: {},
                AssignmentAttemptEvaluation: {},
                PollResponse: {},
                RaiseHandLiveSession: {},
                RaiseHandRecordedSession: {}
            },
            Content: {
                Content: {},
                ContentAudio: {},
                ContentBloomsIndex: {},
                ContentCategory: {},
                ContentComment: {},
                ContentCourse: {},
                ContentLanguage: {},
                ContentLicense: {},
                ContentMediaRating: {},
                ContentRating: {},
                ContentSubtitle: {},
                ContentTopic: {}
            },
            Exams: {
                Assignment: {},
                AssignmentEvaluation: {},
                Exam: {},
                ExamQuestion: {},
                ExamSection: {}
            },
            Institute: {
                Branch: {},
                Department: {},
                Institute: {},
                InstituteDivision: {},
                InstituteStudent: {},
                InstituteTeacher: {},
                InstituteTimeTable: {}
            },
            LiveSessions: {
                LiveSession: {},
                LiveSessionLog: {},
                Poll: {}
            },
            Masters: {
                AcademicPerformance: {},
                AcademicSubjectPerformance: {},
                AcademicYear: {},
                BloomsTaxanomy: {},
                District: {},
                PreAcademic: {},
                PreAcademicScore: {},
                Project: {},
                ProjectSkill: {},
                State: {},
                Taluka: {},
                UserAcademic: {},
                UserSkillsScore: {}
            },
            Playlist: {
                Module: {},
                PlayList: {},
                PlayListContent: {}
            },
            QuestionBank: {
                CommonData: {},
                Question: {},
                QuestionCourse: {},
                QuestionOption: {}
            },
            Settings: {
                Notification: {},
                Sms: {},
                Smtp: {},
                Storage: {}
            },
            Skills: {
                Skill: {},
                SkillCategory: {}
            },
            Syllabus: {
                Class: {},
                Course: {},
                Medium: {},
                Semester: {},
                Subject: {},
                Topic: {}
            },
            Users: {
                Hod: {},
                Principal: {},
                Student: {},
                Teacher: {}
            }
        },
        Forms: {
            Membership: {
                Login: {},
                SendActivation: {},
                SignUp: {}
            }
        },
        Navigation: {},
        Site: {
            AccessDenied: {},
            Layout: {},
            RolePermissionDialog: {},
            UserDialog: {},
            UserPermissionDialog: {},
            ValidationError: {}
        },
        Validation: {}
    }) as any;
}

export const Texts = GXpert.Texts;