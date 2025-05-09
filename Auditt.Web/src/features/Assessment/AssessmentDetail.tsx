import { faArrowCircleLeft } from "@fortawesome/free-solid-svg-icons"
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome"
import { Link } from "react-router-dom"
import { AssessmentCreate } from "./AssessmentCreate"
export const AssessmentDetail = () => {
    return (
        <div className="w-full">
            <div className="flex space-x-4 mb-4 p-4">
                <Link to={'/Assessments'}
                    title='Volver' className="bg-gray-300 hover:bg-gray-300 text-gray-700 hover:text-gray-800 border border-gray-400 hover:border-gray-600 px-4 py-2 rounded font-bold flex items-center transition-all">
                    <FontAwesomeIcon
                        icon={faArrowCircleLeft}
                        className="fa-search top-3 pr-2 font-bold"
                    />Volver
                </Link>
            </div>
            <div className="bg-white p-4 rounded-lg">
                <AssessmentCreate />
            </div>
        </div>
    )
}